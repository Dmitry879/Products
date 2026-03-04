using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Data
{
    public interface IProductRepository
    {
        Task<List<Product>> ShowAllProductsAsync();
        Task<List<Product>> SearchProductsAsync(string searchProd);
        Task<List<Product>> ShowProductsByCategoryAsync(int catId);
        Task<int> AddNewProductAsync(Product prod);
        Task<int> DeleteProductAsync(int prodId);
    }
}
