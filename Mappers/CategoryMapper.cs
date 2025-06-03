using ContactManagerAPI.DAL.Models;
using ContactManagerAPI.DTO.Category;

namespace ContactManagerAPI.Mappers
{
    public static class CategoryMapper
    {
        //Student ID is 00015608
        public static CategoryDto ToCategoryDto(this Category model)
        {
            return new CategoryDto
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                CreatedDate = model.CreatedDate,
                Contacts = model.Contacts.Select(c => c.ToContactDto()).ToList()
            };
        }
        public static Category ToCreateCategory(this CreateCategoryDto categoryDto)
        {
            return new Category
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description,
            };
        }
    }
}
