using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete.Admin;

namespace DataAccess.Repositories.Admin
{
	public class AdminUserRoleDal :
        EFEntityRepositoryBase<AdminUserRole, BarContextDb>,
        IAdminUserRoleDal
    {
    }
    /*
    public class AdminUserRoleDal : IAdminUserRoleDal
   {
       public void Add(AdminUserRole adminUserRole)
       {
           using (var context = new BarContextDb())
           {
               context.aar.Add(adminUserRole);
               context.SaveChanges();
           }
       }

       public void Delete(AdminUserRole adminUserRole)
       {
           using (var context = new BarContextDb())
           {
               context.aar.Remove(adminUserRole);
               context.SaveChanges();
           }
       }

       public AdminUserRole Get(int id)
       {
           using (var context = new BarContextDb())
           {
               return context.aar.Where(p => p.Id == id).FirstOrDefault();
           }
       }

       public List<AdminUserRole> GetAll()
       {
           using (var context = new BarContextDb())
           {
               return context.aar.ToList();
           }
       }

       public void Update(AdminUserRole adminUserRole)
       {
           using (var context = new BarContextDb())
           {
               context.aar.Update(adminUserRole);
               context.SaveChanges();
           }
       }
   }*/
}

