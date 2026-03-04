using MySql.Data.MySqlClient;
using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Data
{
    public class CategoryDAO : ICategoryRepository
    {
        private string _colCatId = "CatID";
        private string _colCatName = "Name";
        private string _colCatDescript = "Description";

        public List<Category> categories = new List<Category>();

        public async Task<List<Category>> ShowAllCategoriesAsync()
        {
            // Define empty list
            var allCategories = new List<Category>();

            // Connect to MySql server
            using var connection = DatabaseConn.GetConnection();
                    // Open connection
                    await connection.OpenAsync();

            // Define the sql statement to fetch all categories
            using var command = new MySqlCommand("SELECT CatID, Name, Description FROM product_categories", connection);

            // Fetch all categories
            using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var category = new Category
                    {
                        Id = reader.GetInt32(reader.GetOrdinal(_colCatId)),
                        Name = reader.GetString(reader.GetOrdinal(_colCatName)),
                        Description = reader.GetString(reader.GetOrdinal(_colCatDescript))
                    };
                    allCategories.Add(category);
                }
            
            return allCategories;
        }

        public async Task<List<Category>> SearchCategoriesAsync(string searchCat)
        {
            var foundCats = new List<Category>();

            using var connection = DatabaseConn.GetConnection();
            await connection.OpenAsync();

            using var command = new MySqlCommand();
                        command.CommandText = "SELECT CatID, Name, Description FROM product_categories WHERE Name LIKE @search";

                        var wildCardSearch = $"%{searchCat}%";
                        command.Parameters.AddWithValue("@search", wildCardSearch);
                        command.Connection = connection;

            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var foundCat = new Category()
                {
                    Id = reader.GetInt32(reader.GetOrdinal(_colCatId)),
                    Name = reader.GetString(reader.GetOrdinal(_colCatName)),
                    Description = reader.GetString(reader.GetOrdinal(_colCatDescript))
                };
                foundCats.Add(foundCat);
            }

            return foundCats;
        }

        public async Task<int> AddNewCategoryAsync(Category cat)
        {

            using var connection = DatabaseConn.GetConnection();
            await connection.OpenAsync();

            var insertQuery = "INSERT INTO product_categories (Name, Description) VALUES (@name, @description)";

            using var command = new MySqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@name", cat.Name);
            command.Parameters.AddWithValue("@description", cat.Description);

            var newCat = await command.ExecuteNonQueryAsync();
            return newCat;
        }

        public async Task<int> DeleteCategoryAsync(int catId)
        {
            using var connection = DatabaseConn.GetConnection();
            await connection.OpenAsync();

            var deleteQuery = "DELETE FROM product_categories WHERE CatID = @catId";
            using var command = new MySqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@catId", catId);

            var removedCat = await command.ExecuteNonQueryAsync();
            return removedCat;

        }
    }
}
