namespace ContactManagerAPI.DAL.Models
{
    //Student ID is 00015608
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation property
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
