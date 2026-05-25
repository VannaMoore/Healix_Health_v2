using System.ComponentModel.DataAnnotations;

namespace HealixAPI.Models
{
    public class Patient
    {
        public Guid PatientId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public DateOnly DateOfBirth { get; set; }

        [Required]
        [MaxLength(11)]
        public string SSN { get; set; } = string.Empty;

    }
}
