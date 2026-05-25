using System.ComponentModel.DataAnnotations;

namespace HealixAPI.Models
{
    public class PatientDemographics
    {
        public Guid PatientDemographicsId { get; set; }
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; } = null!;

        [Required]
        [MaxLength(75)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string City { get; set; } = string.Empty;

        [Required]
        [MaxLength(25)]
        public string State { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public string ZipCode { get; set; } = string.Empty;

        [Required]
        [MaxLength(13)]
        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } // audit trail

        public bool IsCurrent { get; set; } // audit trail
    }
}
