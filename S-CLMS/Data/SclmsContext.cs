using Microsoft.EntityFrameworkCore;
using S_CLMS.Models;

namespace S_CLMS.Data
{
    public class SclmsContext : DbContext
    {
        public SclmsContext(DbContextOptions<SclmsContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<License> Licenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<License>()
                .Property(l => l.Key)
                .IsRequired(false); // Make Key optional

            modelBuilder.Entity<License>()
                .HasOne(l => l.Product)
                .WithMany(p => p.Licenses)
                .HasForeignKey(l => l.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull); // Optional

            modelBuilder.Entity<License>()
                .HasOne(l => l.User)
                .WithMany(u => u.Licenses)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull); // Optional
        }


    }
}
