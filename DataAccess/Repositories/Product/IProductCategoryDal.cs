using System;
using Core.DataAccess.EntityFramework;
using Entities.Concrete.Product;

namespace DataAccess.Repositories.Product
{
	public interface IProductCategoryDal : IEntityRepository<ProductCategory>
    {
    }
    /*public interface IProductCategoryDal
    {
        void Add(ProductCategory ProductCategory);
        void Update(ProductCategory ProductCategory);
        void Delete(ProductCategory ProductCategory);

        List<ProductCategory> GetAll();

        ProductCategory Get(int id);
    }*/
}

