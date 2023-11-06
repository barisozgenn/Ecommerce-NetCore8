using System;
using Business.Services.Admin;
using Business.Utilities.Constants;
using Business.Utilities.File;
using Business.Utilities.Message;
using Business.Validators.FluentValidation.Admin;
using Core.Aspects.Transaction;
using Core.Aspects.Validation;
using Core.Utilities.Hashing;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.Admin;
using Entities.Concrete.Admin;
using Entities.DTOs.Admin;

namespace Business.Managers.Admin
{
    public class AdminUserManager : IAdminUserService //Depenceny Incetion yapacağız program.cs de ki web api den interfaceleri çağırabilelim
    {
        private readonly IAdminUserDal _adminUserDal;
        private readonly IFileService _fileService;
        private readonly IAdminMessageService _adminMessageService;

        public AdminUserManager(IAdminUserDal adminUserDal, IFileService fileService, IAdminMessageService adminMessageService)//ctor tab tab ile constructor oluşturduk böylece programda new leme ve ağırlık yapmadan IAdminUserDal kullanabilicek kıvamda eşleştirdik
        {
            _adminUserDal = adminUserDal;
            _fileService = fileService;
            _adminMessageService = adminMessageService;
        }
        public void Add(RegisterAdminUserAuthDto adminUserAuthDto)
        {
            //Kontroller burada yapılacak
            //DA katmanını kayıt işlemlerini yap burada

            string fileUrl = "";
            if (adminUserAuthDto.ProfileImage != null)
            {
                string path = PathConstants.AdminProfilePicturePath;
                fileUrl = _fileService.FileSave(file: adminUserAuthDto.ProfileImage, filePath: path, fileName: adminUserAuthDto.Username, fileTag: "p");
            }


            _adminUserDal.Add(CreateAdminUser(adminUserAuthDto: adminUserAuthDto, profilePhotoUrl: fileUrl));
        }

        private AdminUser CreateAdminUser(RegisterAdminUserAuthDto adminUserAuthDto, string profilePhotoUrl = "")
        {

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePassword(password: adminUserAuthDto.Password, passwordHash: out passwordHash, passwordSalt: out passwordSalt);//burayada our ekledik ki dönen parametreyi yakalayalım

            return new AdminUser()
            {
                Id = 0,
                Username = adminUserAuthDto.Username,
                Email = adminUserAuthDto.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Role = -1,
                Status = 1,
                ImageUrl = profilePhotoUrl,
                CreatedDate = DateTime.Now
            };
        }
        public AdminUser GetByEmail(string email)
        {
            return _adminUserDal.Get(p => p.Email == email);
        }
        public AdminUser GetByUsername(string username)
        {
            return _adminUserDal.Get(p => p.Username == username);
        }

        [ValidationAspect(typeof(AdminUserValidator))]
        [TransactionAspect()]//eğer bu yapıda bir hata olursa tüm işlemleri geri alır örneğin;
        //kullanıcı sepete ürün ekledi > stok kontrolü yaptı > ödedi - mesela sotok kontrolünde hata olursa sepet işlemini de geri alır
        public IResponse Update(AdminUser adminUser)
        {
            _adminUserDal.Update(entity: adminUser);
            return new ResponseSuccess(statusText: _adminMessageService.GetUpdatedUser(LanguageKey.En));
        }

        public IResponse Delete(AdminUser adminUser)
        {
            _adminUserDal.Delete(entity: adminUser);
            return new ResponseSuccess(statusText: _adminMessageService.GetDeletedUser(LanguageKey.En));
        }

        public IDataResult<List<AdminUser>> GetList()
        {
            return new DataResultSuccess<List<AdminUser>>(data: _adminUserDal.GetAll(), statusText: "success");
        }

        public IDataResult<AdminUser> GetById(int id)
        {
            return new DataResultSuccess<AdminUser>(data: _adminUserDal.Get(p => p.Id == id), statusText: "success");

        }

        [ValidationAspect(typeof(AdminUserPasswordValidator))]
        public IResponse UpdatePassword(AdminUserUpdatePasswordDto adminUserUpdatePasswordDto)
        {
            var adminUser = _adminUserDal.Get(p => p.Id == adminUserUpdatePasswordDto.UserId);

            bool resultPassword = HashingHelper.VerifyPasswordHash(password: adminUserUpdatePasswordDto.CurrentPassword, passwordHash: adminUser.PasswordHash, passwordSalt: adminUser.PasswordSalt);

            if (!resultPassword) return new ResponseFailure(_adminMessageService.GetPasswordCurrentWrong(LanguageKey.En));

            byte[] passwordHash, passwordSalt;

            HashingHelper.CreatePassword(password: adminUserUpdatePasswordDto.NewPassword, passwordHash: out passwordHash, passwordSalt: out passwordSalt);

            adminUser.PasswordHash = passwordHash;
            adminUser.PasswordSalt = passwordSalt;

            _adminUserDal.Update(adminUser);

            return new ResponseSuccess(statusText: _adminMessageService.GetPasswordUpdated(LanguageKey.En));
        }

        public List<AdminRole> GetAdminRoles(int userId)
        {
            return _adminUserDal.GetAdminRoles(userId: userId);
        }
    }
}

