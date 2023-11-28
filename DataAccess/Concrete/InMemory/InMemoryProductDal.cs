using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Glass", UnitPrice = 15, UnitsInStock = 15 },
                new Product
                {
                    ProductId = 1, CategoryId = 1, ProductName = "Camera", UnitPrice = 500, UnitsInStock = 3
                },
                new Product
                {
                    ProductId = 1, CategoryId = 1, ProductName = "Telephone", UnitPrice = 1500, UnitsInStock = 60
                },
                new Product
                {
                    ProductId = 1, CategoryId = 1, ProductName = "Keyboard", UnitPrice = 150, UnitsInStock = 75
                },
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Mouse", UnitPrice = 85, UnitsInStock = 52 }
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(c => c.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
            
    }
}
