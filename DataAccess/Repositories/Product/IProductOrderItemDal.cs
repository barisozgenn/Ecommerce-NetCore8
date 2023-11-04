using System;
using Core.DataAccess.EntityFramework;
using Entities.Concrete.Product;

namespace DataAccess.Repositories.Product
{
	public interface IProductOrderItemDal : IEntityRepository<ProductOrderItem>
    {
    }
    /*public interface IProductOrderItemDal
    {
        void Add(ProductOrderItem ProductOrderItem);
        void Update(ProductOrderItem ProductOrderItem);
        void Delete(ProductOrderItem ProductOrderItem);

        List<ProductOrderItem> GetAll();

        ProductOrderItem Get(int id);
    }*/
}

