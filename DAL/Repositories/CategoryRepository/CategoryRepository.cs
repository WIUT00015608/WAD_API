using ContactManagerAPI.DAL.Models;
using ContactManagerAPI.DTO.Category;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerAPI.DAL.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<Category> CreateAsync(Category category)
        {
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }
        public async Task<Category?> UpdateAsync(int id, UpdateCategoryDto updateDto)
        {
            var isExist = await _context.Categories.FindAsync(id);

            if (isExist == null)
            {
                return null;
            }

            isExist.Name = updateDto.Name;
            isExist.Description = updateDto.Description;

            await _context.SaveChangesAsync();
            return isExist;
        }

        public async Task<Category?> DeleteAsync(int id)
        {
            var isExist = await _context.Categories.FindAsync(id);
            if (isExist == null)
            {
                return null;
            }
            _context.Categories.Remove(isExist);
            await _context.SaveChangesAsync();
            return isExist;
        }
    }
}
