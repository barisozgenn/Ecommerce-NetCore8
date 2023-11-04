using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete.User;

namespace DataAccess.Repositories.User
{
	public class UserDetailDal :
        EFEntityRepositoryBase<UserDetail, BarContextDb>,
        IUserDetailDal
    {

    }
    /*
   public class UserDetailDal : IUserDetailDal
  {
      public void Add(UserDetail UserDetail)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Add(UserDetail);
              context.SaveChanges();
          }
      }

      public void Delete(UserDetail UserDetail)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Remove(UserDetail);
              context.SaveChanges();
          }
      }

      public UserDetail Get(int id)
      {
          using (var context = new BarContextDb())
          {
              return context.aar.Where(p => p.Id == id).FirstOrDefault();
          }
      }

      public List<UserDetail> GetAll()
      {
          using (var context = new BarContextDb())
          {
              return context.aar.ToList();
          }
      }

      public void Update(UserDetail UserDetail)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Update(UserDetail);
              context.SaveChanges();
          }
      }
  }*/
}

