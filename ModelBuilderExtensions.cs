using Microsoft.EntityFrameworkCore;

namespace CarDescription_Backend.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarMaker>().HasData(
                new CarMaker { Id = 1, Name = "Ford" },
                new CarMaker { Id = 2, Name = "BMW" },
                new CarMaker { Id = 3, Name = "Tesla" },
                new CarMaker { Id = 4, Name = "Honda" },
                new CarMaker { Id = 5, Name = "Chevrolet" });

            modelBuilder.Entity<CarModel>().HasData(
                new CarModel { Id = 1, CarMakerId = 1, Name = "Fiesta", BodyType = "Hatchback", FuelType = "Unleaded", Efficiency = 31, StartingPrice = 14260, IsBeingProduced = true },
                new CarModel { Id = 2, CarMakerId = 2, Name = "5 Series", BodyType = "Sedan", FuelType = "Unleaded", Efficiency = 33, StartingPrice = 54800, IsBeingProduced = true },
                new CarModel { Id = 3, CarMakerId = 3, Name = "Model 3", BodyType = "Sedan", FuelType = "Electricity", Efficiency = 250, StartingPrice = 44990, IsBeingProduced = true },
                new CarModel { Id = 4, CarMakerId = 4, Name = "CR-Z", BodyType = "Coupe", FuelType = "Hybrid", Efficiency = 36, StartingPrice = 20295, IsBeingProduced = false },
                new CarModel { Id = 5, CarMakerId = 5, Name = "Camaro", BodyType = "Convertible", FuelType = "Unleaded", Efficiency = 22, StartingPrice = 25800, IsBeingProduced = true });
        }
    }
}
