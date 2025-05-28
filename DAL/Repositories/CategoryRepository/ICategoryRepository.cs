using ContactManagerAPI.DAL.Models;
using ContactManagerAPI.DTO.Category;

namespace ContactManagerAPI.DAL.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();
        Task<Category?> GetByIdAsync(int id);
        Task<Category> CreateAsync(Category category);
        Task<Category?> UpdateAsync(int id, UpdateCategoryDto updateDto);
        Task<Category?> DeleteAsync(int id);
    }
}
