using ContactManagerAPI.DAL.Models;
using ContactManagerAPI.DTO.Category;
using ContactManagerAPI.DTO.Contact;

namespace ContactManagerAPI.Mappers
{
    public static class ContactMappers
    {
        public static ContactDto ToContactDto(this Contact model)
        {
            return new ContactDto
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Phone = model.Phone,
                Address = model.Address,
                CreatedDate = model.CreatedDate,
                UpdatedDate = model.UpdatedDate,
                CategoryId = model.CategoryId
            };
        }
        public static Contact ToCreateContact(this CreateContactDto contactDto)
        {
            return new Contact
            {
                FirstName = contactDto.FirstName,
                LastName = contactDto.LastName,
                Email = contactDto.Email,
                Phone = contactDto.Phone,
                Address = contactDto.Address,
                CategoryId = contactDto.CategoryId
            };
        }
    }
}
