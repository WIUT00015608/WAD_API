using ContactManagerAPI.DAL.Models;

namespace ContactManagerAPI.DTO.Category
{
    public class UpdateCategoryDto
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
