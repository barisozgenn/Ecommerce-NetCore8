using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete.Product;

namespace DataAccess.Repositories.Product
{
	public class ProductOrderItemDal :
        EFEntityRepositoryBase<ProductOrderItem, BarContextDb>,
        IProductOrderItemDal
    {

    }
    /*
   public class ProductOrderItemDal : IProductOrderItemDal
  {
      public void Add(ProductOrderItem ProductOrderItem)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Add(ProductOrderItem);
              context.SaveChanges();
          }
      }

      public void Delete(ProductOrderItem ProductOrderItem)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Remove(ProductOrderItem);
              context.SaveChanges();
          }
      }

      public ProductOrderItem Get(int id)
      {
          using (var context = new BarContextDb())
          {
              return context.aar.Where(p => p.Id == id).FirstOrDefault();
          }
      }

      public List<ProductOrderItem> GetAll()
      {
          using (var context = new BarContextDb())
          {
              return context.aar.ToList();
          }
      }

      public void Update(ProductOrderItem ProductOrderItem)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Update(ProductOrderItem);
              context.SaveChanges();
          }
      }
  }*/
}

