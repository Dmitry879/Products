using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Data
{
    public class ProductDAO : IProductRepository
    {
        private string _colProdId = "ProductId";
        private string _colProdName = "Name";
        private string _colProdDescript = "Description";
        private string _colProdWsPrice = "WholesalePrice";
        private string _colProdRetPrice = "RetailPrice";
        private string _colProdVenId = "VendorID";
        private string _colCatId = "CatID";
        
        public async Task<List<Product>> ShowAllProductsAsync()
        {
            var allProducts = new List<Product>();
            
            using var connection = DatabaseConn.GetConnection();
            await connection.OpenAsync();

            var showProdsQuery = "SELECT ProductID, Name, Description, WholesalePrice, RetailPrice, VendorID, CatID FROM products";
            var command = new MySqlCommand(showProdsQuery, connection);

            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var prod = CreateProductObj(reader);
                allProducts.Add(prod);
            }

            return allProducts;
        }
        public async Task<List<Product>> SearchProductsAsync(string searchProd)
        {
            var foundProds = new List<Product>();

            using var connection = DatabaseConn.GetConnection();
            await connection.OpenAsync();

            var searchQuery = "SELECT ProductID, Name, Description, WholesalePrice, RetailPrice, VendorID, CatID FROM products WHERE Name LIKE @searchName";
            using var command = new MySqlCommand(searchQuery, connection);
            command.Parameters.AddWithValue("@searchName", $"%{searchProd}%");

            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var foundProd = CreateProductObj(reader);
                foundProds.Add(foundProd);
            }

            return foundProds;
        }

        public async Task<List<Product>> ShowProductsByCategoryAsync(int catId)
        {
            var catProds = new List<Product>();

            using var connection = DatabaseConn.GetConnection();
            await connection.OpenAsync();

            var catProdsQuery = "SELECT ProductID, Name, Description, WholesalePrice, RetailPrice, VendorID, CatID FROM products WHERE CatID = @catId";
            using var command = new MySqlCommand(catProdsQuery, connection);
            command.Parameters.AddWithValue("@catId", catId);

            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var catProd = CreateProductObj(reader);
                catProds.Add(catProd);
            }

            return catProds;
        }


        public async Task<int> AddNewProductAsync(Product prod)
        {
            using var connection = DatabaseConn.GetConnection();
            await connection.OpenAsync();

            var addQuery = "INSERT INTO products (Name, Description, WholesalePrice, RetailPrice, VendorID, CatID) VALUES(@name, @description, @wholesale, @retail, @vendorId, @catId)";

            using var command = new MySqlCommand(addQuery, connection);
            command.Parameters.AddWithValue("@name", prod.Name);
            command.Parameters.AddWithValue("@description", prod.Description);
            command.Parameters.AddWithValue("wholesale", prod.WholesalePrice);
            command.Parameters.AddWithValue("@retail", prod.RetailPrice);
            command.Parameters.AddWithValue("@vendorId", prod.VendorId);
            command.Parameters.AddWithValue("@catId", prod.CatId);
            var addResult = await command.ExecuteNonQueryAsync();

            return addResult;
        }

        public async Task<int> DeleteProductAsync(int prodId)
        {
            using var connection = DatabaseConn.GetConnection();
            await connection.OpenAsync();

            var deleteQuery = "DELETE FROM products WHERE ProductID = @prodId";
            using var command = new MySqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@prodId", prodId);

            var delResult = await command.ExecuteNonQueryAsync();

            return delResult;
        }

        // Helper method to assign database values to a new Product object
        private Product CreateProductObj(System.Data.Common.DbDataReader reader)
        {
            return new Product
            {
                Id = reader.GetInt32(reader.GetOrdinal(_colProdId)),
                Name = reader.GetString(reader.GetOrdinal(_colProdName)),
                Description = reader.GetString(reader.GetOrdinal(_colProdDescript)),
                WholesalePrice = reader.GetDecimal(reader.GetOrdinal(_colProdWsPrice)),
                RetailPrice = reader.GetDecimal(reader.GetOrdinal(_colProdRetPrice)),
                VendorId = reader.GetInt32(reader.GetOrdinal(_colProdVenId)),
                CatId = reader.GetInt32(reader.GetOrdinal(_colCatId))
            };
        }
    }
}
