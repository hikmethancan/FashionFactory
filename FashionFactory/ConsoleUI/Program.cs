using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            var products = productManager.GetAll();
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
