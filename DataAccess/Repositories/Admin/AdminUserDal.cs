using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.Admin;

namespace DataAccess.Repositories.Admin
{
    public class AdminUserDal :
        EFEntityRepositoryBase<AdminUser, BarContextDb>,
        IAdminUserDal
    {
        public List<AdminRole> GetAdminRoles(int userId)
        {
            using (var context = new BarContextDb())
            {
                var result = from adminUserRole in context.AdminUserRoles?.Where(p => p.AdminId == userId)
                             join adminRole in context.AdminRoles on adminUserRole.Id equals adminRole.Id
                             select new AdminRole
                             {
                                 Id = adminRole.Id,
                                 Name = adminRole.Name
                             };
                return result.OrderBy(p => p.Name).ToList();
            }
        }
    }
    /*
       public class AdminUserDal : IAdminUserDal
       {
           public void Add(AdminUser adminUser)
           {
               using (var context = new BarContextDb())
               {
                   context.ada.Add(adminUser);
                   context.SaveChanges();
               }
           }

           public void Delete(AdminUser adminUser)
           {
               using (var context = new BarContextDb())
               {
                   context.ada.Remove(adminUser);
                   context.SaveChanges();
               }
           }

           public AdminUser Get(int id)
           {
               using (var context = new BarContextDb())
               {
                   var adminUser = context.ada.Where(p => p.Id == id).FirstOrDefault();

                   return adminUser;
               }
           }

           public List<AdminUser> GetAll()
           {
               using (var context = new BarContextDb())
               {
                   return context.ada.ToList();
               }
           }

           public void Update(AdminUser adminUser)
           {
               using (var context = new BarContextDb())
               {
                   context.ada.Update(adminUser);
                   context.SaveChanges();
               }
           }
       }
        */
}

