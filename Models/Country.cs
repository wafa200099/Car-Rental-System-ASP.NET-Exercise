using System.ComponentModel.DataAnnotations;

namespace CarRentalSystem.Models
{
    public class Country
    {
        public int CountryId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; } 
    }

}
