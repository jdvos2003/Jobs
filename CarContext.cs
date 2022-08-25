using Microsoft.EntityFrameworkCore;

namespace CarDescription_Backend.Models
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarMaker>()
                .HasMany(c => c.CarModels)
                .WithOne(a => a.CarMaker)
                .HasForeignKey(a => a.CarMakerId);

            modelBuilder.Seed();
        }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarMaker> CarMakers { get; set; }
    }

}
