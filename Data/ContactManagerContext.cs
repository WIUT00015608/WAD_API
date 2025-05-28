using ContactManagerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerAPI.Data
{
    public class ContactManagerContext: DbContext
    {
        public ContactManagerContext(DbContextOptions dbContextOptions): base(dbContextOptions) 
        { 
        
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
