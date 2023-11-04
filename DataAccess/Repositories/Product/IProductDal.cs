using System;
using Core.DataAccess.EntityFramework;
using Entities.Concrete.Product;

namespace DataAccess.Repositories.Product
{
	public interface IProductDal : IEntityRepository<Entities.Concrete.Product.Product>
    {
    }
    /*public interface IProductDal
    {
        void Add(Product Product);
        void Update(Product Product);
        void Delete(Product Product);

        List<Product> GetAll();

        Product Get(int id);
    }*/
}

