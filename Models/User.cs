using System.ComponentModel.DataAnnotations;

namespace CarRentalSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        [StringLength(200)]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        public int CountryId { get; set; }
        public Country Country { get; set; } 

        [Required]
        [StringLength(50)]
        public string DriversLicenseNumber { get; set; }

        public ICollection<Reservation> Reservations { get; set; } 
    }


}
