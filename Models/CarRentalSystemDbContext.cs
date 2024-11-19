using Microsoft.EntityFrameworkCore;
using CarRentalSystem.Models;
using System;

public class CarRentalSystemDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Country> Countries { get; set; }

    public CarRentalSystemDbContext(DbContextOptions<CarRentalSystemDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Country>().HasData(
            new Country { CountryId = 1, Name = "USA" },
            new Country { CountryId = 2, Name = "Canada" }
        );

        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@example.com",
                Password = "password123",
                ConfirmPassword = "password123",
                PhoneNumber = "1234567890",
                DateOfBirth = new DateTime(1990, 1, 1),
                AddressLine1 = "123 Main St",
                AddressLine2 = "Apt 4B",
                City = "New York",
                CountryId = 1,  // USA
                DriversLicenseNumber = "D1234567890"
            },
            new User
            {
                UserId = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Email = "janesmith@example.com",
                Password = "password456",  
                ConfirmPassword = "password456",
                PhoneNumber = "0987654321",
                DateOfBirth = new DateTime(1992, 5, 15),
                AddressLine1 = "456 Elm St",
                AddressLine2 = "",
                City = "Toronto",
                CountryId = 2,  // Canada
                DriversLicenseNumber = "D9876543210"
            }
        );


        modelBuilder.Entity<Car>().HasData(
            new Car
            {
                CarId = 1,
                Make = "Toyota",
                Model = "Camry",
                Year = 2020,
                PricePerDay = 50.00M,
                IsAvailable = true,
                Description = "A reliable and fuel-efficient sedan."
            },
            new Car
            {
                CarId = 2,
                Make = "Honda",
                Model = "Civic",
                Year = 2021,
                PricePerDay = 55.00M,
                IsAvailable = true,
                Description = "A compact car with great performance."
            },
            new Car
            {
                CarId = 3,
                Make = "Ford",
                Model = "Focus",
                Year = 2022,
                PricePerDay = 60.00M,
                IsAvailable = false,  
                Description = "A sporty and modern car with advanced features."
            }
        );
    }
}
