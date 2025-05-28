using ContactManagerAPI.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerAPI.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) :base(dbContextOptions) 
        { 
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
