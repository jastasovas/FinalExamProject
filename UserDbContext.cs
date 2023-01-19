using FinalExam.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalExam
{
    public class UserDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne<Human>(u => u.Human)
                .WithOne(fn => fn.User)
                .HasForeignKey<Human>(fn => fn.UserId);

            //modelBuilder.Entity<Human>()
            //    .HasOne<Address>(a => a.Address)
            //    .WithOne(ad => ad.Human)
            //    .HasForeignKey<Address>(ad => ad.HumanId);
        }

        public DbSet<User> Users { get; set; }  
        public DbSet<Human> Humans { get; set; }    
        public DbSet<Address> Addresses { get; set; }
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
    }
}
