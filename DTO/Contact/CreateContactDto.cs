namespace ContactManagerAPI.DTO.Contact
{
    public class CreateContactDto
    {
        //Student ID is 00015608
        public required string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public int? CategoryId { get; set; }
    }
}
