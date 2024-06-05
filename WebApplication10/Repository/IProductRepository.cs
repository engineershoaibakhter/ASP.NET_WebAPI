using WebApplication10.Models;
using System.Collections.Generic;

namespace WebApplication10.Repository
{
    public interface IProductRepository
    {
        Product GetProductById(int productId);
        IEnumerable<Product> GetProducts();
        void DeleteProduct(int productId);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void Save();
    }
}
