using System;
using Business.Services.Admin;
using Business.Utilities.Constants;
using Business.Utilities.Message;
using Business.Validators.FluentValidation.Admin;
using Core.Aspects.Validation;
using Core.Utilities.Business;
using Core.Utilities.Hashing;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using Core.Utilities.Security.JWT;
using Entities.Concrete.Admin;
using Entities.DTOs.Admin;

namespace Business.Managers.Admin
{
	public class AdminAuthManager : IAdminAuthService
    {
        private readonly IAdminUserService _adminUserService;
        private readonly ITokenHandler _tokenHandler;
        private readonly IAdminMessageService _adminMessageService;

        public AdminAuthManager(IAdminUserService adminUserService, ITokenHandler tokenHandler, IAdminMessageService adminMessageService)
        {
            _adminUserService = adminUserService;
            _tokenHandler = tokenHandler;
            _adminMessageService = adminMessageService;
        }

        [ValidationAspect(typeof(AuthAdminValidator))]//AOP : işlemden önce bunlar bir çalışsın ve dependency yap // metot içinde yazılan attribute olarak metotun dışına alıp cross cutting destekli olarak kontrol edelim
        //[LogAspect]//işlem bittikten sonra 
        public IResponse RegisterByAdmin(RegisterAdminUserAuthDto registerDto)
        {
            //FluentValidation parametre kontrolleri için kullanılabilir güzel.
            /*AdminUserValidator adminUserValidator = new AdminUserValidator();
            ValidationResult validationResult = adminUserValidator.Validate(instance: registerDto);*/

            /*if (validationResult.IsValid)
            {
                _adminUserService.Add(registerDto: registerDto);
                return new List<string> { "Admin User is Created" };
            }
            else return validationResult.Errors.Select(p=> p.ErrorMessage).ToList();*/

            //Uygulamayı Corss Cutting yaparak dikine keselim ve FluentValidation kullanalım sonrada AOP yapalım

            //AdminUserValidator adminUserValidator = new AdminUserValidator();
            //ValidationTool.Validatie(validator: adminUserValidator, entity: registerDto);




            IResponse responseCheck = BusinessRules.Run(
                  CheckAdminUserExist(adminUserDto: registerDto),
                  CheckImageExentison(registerDto: registerDto),
                  CheckAdminImage(registerDto: registerDto)
                );
            if (responseCheck.Status)
            {
                _adminUserService.Add(registerDto: registerDto);

                responseCheck.StatusText = $"{registerDto.Username} admin User is created.";
            }

            return responseCheck;
        }

        public IDataResult<Token> Login(LoginAdminUserAuthDto loginDto)
        {
            var adminUser = _adminUserService.GetByEmail(email: loginDto.Email);
            if (adminUser == null) return new DataResultFailure<Token>(statusText: _adminMessageService.GetUsernameOrPasswordWrong(LanguageKey.En));

            var result = HashingHelper.VerifyPasswordHash(password: loginDto.Password, passwordHash: adminUser.PasswordHash, passwordSalt: adminUser.PasswordSalt);

            List<AdminRole> adminRoles = _adminUserService.GetAdminRoles(userId: adminUser.Id);

            if (result)
            {
                Token token = new Token();
                token = _tokenHandler.CreateToken(adminUser: adminUser, adminRoles: adminRoles);
                return new DataResultSuccess<Token>(token);
            }
            return new DataResultFailure<Token>(statusText: _adminMessageService.GetUsernameOrPasswordWrong(LanguageKey.En));
        }


        private IResponse CheckAdminUserExist(RegisterAdminUserAuthDto adminUserDto)
        {
            var list = _adminUserService.GetByEmail(email: adminUserDto.Email);
            if (list != null) return new ResponseFailure(statusText: "This email exists already!");
            list = _adminUserService.GetByUsername(username: adminUserDto.Username);
            if (list != null) return new ResponseFailure(statusText: "This username exists already!");

            return new ResponseSuccess(statusText: "The username and email you entered are suitable for admin registration.");
        }

        private IResponse CheckAdminImage(RegisterAdminUserAuthDto registerDto)
        {

            if (registerDto.ProfileImage != null)
            {
                double imageSizeKB = registerDto.ProfileImage.Length * 0.001;

                if (imageSizeKB > 1024) return new ResponseFailure(statusText: "Profile image size must be less than 1mb!");
            }


            return new ResponseSuccess(statusText: "Image size is OK");
        }

        private IResponse CheckImageExentison(RegisterAdminUserAuthDto registerDto)
        {

            if (registerDto.ProfileImage != null)
            {
                var extension = "." + registerDto.ProfileImage.FileName.Split(".").Last().ToLower();

                List<string> AllowFileExentions = new List<string> { ".jpg", ".jpeg", ".png" };
                if (!AllowFileExentions.Contains(extension))
                {
                    return new ResponseFailure(statusText: "Image type must be standart such as jpg or png");
                }
            }
            return new ResponseSuccess(statusText: "Image type is OK");
        }
    }
}


