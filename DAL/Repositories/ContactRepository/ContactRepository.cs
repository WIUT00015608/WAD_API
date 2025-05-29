using ContactManagerAPI.DAL.Models;
using ContactManagerAPI.DTO.Category;
using ContactManagerAPI.DTO.Contact;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerAPI.DAL.Repositories.ContactRepository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;
        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Contact>> GetAllAsync()
        {
            return await _context.Contacts.ToListAsync();
        }
        public async Task<Contact?> GetByIdAsync(int id)
        {
            return await _context.Contacts.FindAsync(id);
        }
        public async Task<Contact> CreateAsync(Contact contact)
        {
            await _context.AddAsync(contact);
            await _context.SaveChangesAsync();
            return contact;
        }

        public async Task<Contact?> UpdateAsync(int id, UpdateContactDto updateDto)
        {
            var isExist = await _context.Contacts.FindAsync(id);
            if (isExist == null)
            {
                return null;
            }
            isExist.FirstName = updateDto.FirstName;
            isExist.LastName = updateDto.LastName;
            isExist.Email = updateDto.Email;
            isExist.Phone = updateDto.Phone;
            isExist.Address = updateDto.Address;
            isExist.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return isExist;
        }

        public async Task<Contact?> DeleteAsync(int id)
        {
            var isExist = await _context.Contacts.FindAsync(id);
            if (isExist == null)
            {
                return null;
            }
            _context.Contacts.Remove(isExist);
            await _context.SaveChangesAsync();
            return isExist;
        }
    }
}
