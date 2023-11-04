using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete.User;

namespace DataAccess.Repositories.User
{
	public class UserDal :
        EFEntityRepositoryBase<Entities.Concrete.User.User, BarContextDb>,
        IUserDal
    {

    }
    /*
   public class UserDal : IUserDal
  {
      public void Add(User User)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Add(User);
              context.SaveChanges();
          }
      }

      public void Delete(User User)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Remove(User);
              context.SaveChanges();
          }
      }

      public User Get(int id)
      {
          using (var context = new BarContextDb())
          {
              return context.aar.Where(p => p.Id == id).FirstOrDefault();
          }
      }

      public List<User> GetAll()
      {
          using (var context = new BarContextDb())
          {
              return context.aar.ToList();
          }
      }

      public void Update(User User)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Update(User);
              context.SaveChanges();
          }
      }
  }*/
}

