using ContactManagerAPI.DAL.Models;
using ContactManagerAPI.DTO.Category;
using ContactManagerAPI.DTO.Contact;

namespace ContactManagerAPI.DAL.Repositories.ContactRepository
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetAllAsync();
        Task<Contact?> GetByIdAsync(int id);
        Task<Contact> CreateAsync(Contact contact);
        Task<Contact?> UpdateAsync(int id, UpdateContactDto updateDto);
        Task<Contact?> DeleteAsync(int id);
    }
}
