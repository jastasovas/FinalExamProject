using FinalExam.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalExam
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }  
        public DbSet<Human> Humans { get; set; }    
        public DbSet<Address> Addresses { get; set; }
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
    }
}
