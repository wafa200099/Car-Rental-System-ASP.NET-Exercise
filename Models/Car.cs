using System.ComponentModel.DataAnnotations;

namespace CarRentalSystem.Models
{

    public class Car
    {
        public int CarId { get; set; }

        [Required]
        [StringLength(100)]
        public string Make { get; set; }

        [Required]
        [StringLength(100)]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public decimal PricePerDay { get; set; }

        public string Description { get; set; }

        public bool IsAvailable { get; set; } // Whether the car is available for rent

        public ICollection<Reservation> Reservations { get; set; } // A car can be reserved multiple times
    }

}
