namespace ContactManagerAPI.DAL.Models
{
    //Student ID is 00015608
    public class Contact
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

        // Foreign key
        public int? CategoryId { get; set; }

        // Navigation property
        public Category? Category { get; set; }
    }
}
