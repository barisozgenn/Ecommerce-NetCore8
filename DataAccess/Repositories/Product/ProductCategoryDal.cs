using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using DataAccess.Repositories.Product;
using Entities.Concrete.Product;

namespace DataAccess.Repositories.Product
{
	public class ProductCategoryDal :
        EFEntityRepositoryBase<ProductCategory, BarContextDb>,
        IProductCategoryDal
    {

    }
    /*
   public class ProductCategoryDal : IProductCategoryDal
  {
      public void Add(ProductCategory ProductCategory)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Add(ProductCategory);
              context.SaveChanges();
          }
      }

      public void Delete(ProductCategory ProductCategory)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Remove(ProductCategory);
              context.SaveChanges();
          }
      }

      public ProductCategory Get(int id)
      {
          using (var context = new BarContextDb())
          {
              return context.aar.Where(p => p.Id == id).FirstOrDefault();
          }
      }

      public List<ProductCategory> GetAll()
      {
          using (var context = new BarContextDb())
          {
              return context.aar.ToList();
          }
      }

      public void Update(ProductCategory ProductCategory)
      {
          using (var context = new BarContextDb())
          {
              context.aar.Update(ProductCategory);
              context.SaveChanges();
          }
      }
  }*/
}

