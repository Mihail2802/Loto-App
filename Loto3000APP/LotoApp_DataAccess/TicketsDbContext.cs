using Loto3000App_Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LotoApp_DataAccess
{
    public class TicketsDbContext : DbContext
    {
        public TicketsDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .Property(x => x.FirstName)
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(x => x.Lastname)
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(x => x.UserName)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasIndex(x => x.UserName)
                .IsUnique();

            modelBuilder.Entity<User>()
                .Property(x => x.Age)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasMany(x => x.Tickets)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Ticket>()
                .Property(x => x.Numbers)
                .IsRequired();

        }
    }
}
