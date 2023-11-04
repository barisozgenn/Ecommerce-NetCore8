using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete.User;

namespace DataAccess.Repositories.User
{
	public class UserAddressDal :
        EFEntityRepositoryBase<UserAddress, BarContextDb>,
        IUserAddressDal
    {

    }
    /*
   public class UserAddressDal : IUserAddressDal
  {
      public void Add(UserAddress UserAddress)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Add(UserAddress);
              context.SaveChanges();
          }
      }

      public void Delete(UserAddress UserAddress)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Remove(UserAddress);
              context.SaveChanges();
          }
      }

      public UserAddress Get(int id)
      {
          using (var context = new BarContextDb())
          {
              return context.aar.Where(p => p.Id == id).FirstOrDefault();
          }
      }

      public List<UserAddress> GetAll()
      {
          using (var context = new BarContextDb())
          {
              return context.aar.ToList();
          }
      }

      public void Update(UserAddress UserAddress)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Update(UserAddress);
              context.SaveChanges();
          }
      }
  }*/
}

