using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HealixAPI.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Required]
        [MaxLength (50)]
        public string FirstName = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName = string.Empty;

        //email and role inherits from IdentityUser class.
    }
}
