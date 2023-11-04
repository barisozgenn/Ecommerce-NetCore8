using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete.Product;

namespace DataAccess.Repositories.Product
{
	public class ProductDal :
        EFEntityRepositoryBase<Entities.Concrete.Product.Product, BarContextDb>,
        IProductDal
    {

    }
    /*
   public class ProductDal : IProductDal
  {
      public void Add(Product Product)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Add(Product);
              context.SaveChanges();
          }
      }

      public void Delete(Product Product)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Remove(Product);
              context.SaveChanges();
          }
      }

      public Product Get(int id)
      {
          using (var context = new BarContextDb())
          {
              return context.aar.Where(p => p.Id == id).FirstOrDefault();
          }
      }

      public List<Product> GetAll()
      {
          using (var context = new BarContextDb())
          {
              return context.aar.ToList();
          }
      }

      public void Update(Product Product)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Update(Product);
              context.SaveChanges();
          }
      }
  }*/
}

