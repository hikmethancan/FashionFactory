using Entity.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        
        List<Product> GetById(int categoryId);
    }
}
