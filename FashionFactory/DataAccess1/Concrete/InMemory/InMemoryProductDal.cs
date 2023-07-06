using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product {ProductId = 1, ColorId = 2, ProductName = "Short", DailyPrice = 199.999, Description = "Comfortable", ModelYear = 2023},
                new Product {ProductId = 1, ColorId = 2, ProductName = "Pants", DailyPrice = 399.999, Description = "Comfortable", ModelYear = 2023},
                new Product {ProductId = 1, ColorId = 2, ProductName = "Underwear", DailyPrice = 999.999, Description = "Comfortable", ModelYear = 2020},
                new Product {ProductId = 1, ColorId = 2, ProductName = "Hat", DailyPrice = 99.999, Description = "Comfortable", ModelYear = 2022},
                new Product {ProductId = 1, ColorId = 2, ProductName = "Glass", DailyPrice = 2199.999, Description = "Comfortable", ModelYear = 2021},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            var productToDelete = _products.Where(p=> p.ProductId == product.ProductId).ToList();

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
