using System.ComponentModel.DataAnnotations;
namespace CarRentalSystem.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } 

        public int CarId { get; set; }
        public Car Car { get; set; } 

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public decimal TotalPrice { get; set; }

        public bool IsCompleted { get; set; }
    }


}
