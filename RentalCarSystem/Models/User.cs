using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RentalCarSystem.Models
{
    public class User:IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public DateTime? DOB { get; set; }
        [Required]
        public string City {  get; set; }
        [Required]
        public string Country { get; set; }
    }
}
