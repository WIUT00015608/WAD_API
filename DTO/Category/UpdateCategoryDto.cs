using ContactManagerAPI.DAL.Models;

namespace ContactManagerAPI.DTO.Category
{
    //Student ID is 00015608
    public class UpdateCategoryDto
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
