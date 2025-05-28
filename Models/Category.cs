namespace ContactManagerAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation property
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
