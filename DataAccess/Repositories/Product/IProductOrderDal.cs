using System;
using Core.DataAccess.EntityFramework;
using Entities.Concrete.Product;

namespace DataAccess.Repositories.Product
{
	public interface IProductOrderDal : IEntityRepository<ProductOrder>
    {
    }
    /*public interface IProductOrderDal
    {
        void Add(ProductOrder ProductOrder);
        void Update(ProductOrder ProductOrder);
        void Delete(ProductOrder ProductOrder);

        List<ProductOrder> GetAll();

        ProductOrder Get(int id);
    }*/
}

