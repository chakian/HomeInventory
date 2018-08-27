using HomeInventory.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeInventory.Data
{
    public class HiContext : DbContext
    {
        public DbSet<Home> Home { get; set; }

        public DbSet<Family> Family { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=homeinventory;user=root;password=q1w2");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Home>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Description);
            });

            modelBuilder.Entity<Family>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Description);
                //entity.HasOne(d => d.Publisher)
                //  .WithMany(p => p.Books);
            });
        }
    }
}
