using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete.Admin;

namespace DataAccess.Repositories.Admin
{
    public class AdminRoleDal :
        EFEntityRepositoryBase<AdminRole, BarContextDb>,
        IAdminRoleDal
    {
    }
    /*
   public class AdminRoleDal : IAdminRoleDal
  {
      public void Add(AdminRole adminRole)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Add(adminRole);
              context.SaveChanges();
          }
      }

      public void Delete(AdminRole adminRole)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Remove(adminRole);
              context.SaveChanges();
          }
      }

      public AdminRole Get(int id)
      {
          using (var context = new BarContextDb())
          {
              return context.aar.Where(p => p.Id == id).FirstOrDefault();
          }
      }

      public List<AdminRole> GetAll()
      {
          using (var context = new BarContextDb())
          {
              return context.aar.ToList();
          }
      }

      public void Update(AdminRole adminRole)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Update(adminRole);
              context.SaveChanges();
          }
      }
  }*/
}

