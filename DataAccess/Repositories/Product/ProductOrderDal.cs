using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete.Product;

namespace DataAccess.Repositories.Product
{
	public class ProductOrderDal :
        EFEntityRepositoryBase<ProductOrder, BarContextDb>,
        IProductOrderDal
    {

    }
    /*
   public class ProductOrderDal : IProductOrderDal
  {
      public void Add(ProductOrder ProductOrder)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Add(ProductOrder);
              context.SaveChanges();
          }
      }

      public void Delete(ProductOrder ProductOrder)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Remove(ProductOrder);
              context.SaveChanges();
          }
      }

      public ProductOrder Get(int id)
      {
          using (var context = new BarContextDb())
          {
              return context.aar.Where(p => p.Id == id).FirstOrDefault();
          }
      }

      public List<ProductOrder> GetAll()
      {
          using (var context = new BarContextDb())
          {
              return context.aar.ToList();
          }
      }

      public void Update(ProductOrder ProductOrder)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Update(ProductOrder);
              context.SaveChanges();
          }
      }
  }*/
}

