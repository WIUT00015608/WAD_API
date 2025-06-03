using ContactManagerAPI.DTO.Contact;

namespace ContactManagerAPI.DTO.Category
{
    //Student ID is 00015608
    public class CategoryDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<ContactDto>? Contacts { get; set; }
    }
}
