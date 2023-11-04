using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete.Admin;
namespace DataAccess.Repositories.Admin
{
    public class AdminEmailParameterDal :
        EFEntityRepositoryBase<AdminEmailParameter, BarContextDb>,
        IAdminEmailParameterDal
    {
      
    }
    /*
   public class AdminEmailParameterDal : IAdminEmailParameterDal
  {
      public void Add(AdminEmailParameter adminEmailParameter)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Add(adminEmailParameter);
              context.SaveChanges();
          }
      }

      public void Delete(AdminEmailParameter adminEmailParameter)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Remove(adminEmailParameter);
              context.SaveChanges();
          }
      }

      public AdminEmailParameter Get(int id)
      {
          using (var context = new BarContextDb())
          {
              return context.aar.Where(p => p.Id == id).FirstOrDefault();
          }
      }

      public List<AdminEmailParameter> GetAll()
      {
          using (var context = new BarContextDb())
          {
              return context.aar.ToList();
          }
      }

      public void Update(AdminEmailParameter adminEmailParameter)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Update(adminEmailParameter);
              context.SaveChanges();
          }
      }
  }*/
}

