using Products.Models;

namespace Products.Data
{
    public interface ICategoryRepository
    {
        Task<List<Category>> SearchCategoriesAsync(string searchCat);
        Task<List<Category>> ShowAllCategoriesAsync();
        Task<int> AddNewCategoryAsync(Category cat);
        Task<int> DeleteCategoryAsync(int catId);
    }
}