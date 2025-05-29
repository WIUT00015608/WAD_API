namespace ContactManagerAPI.DTO.Contact
{
    public class ContactDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CategoryId { get; set; }
    }
}
