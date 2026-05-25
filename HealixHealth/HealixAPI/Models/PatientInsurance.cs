using System.ComponentModel.DataAnnotations;

namespace HealixAPI.Models
{
    public class PatientInsurance
    {
        public Guid PatientInsuranceId { get; set; }
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; } = null!;
        public int InsuranceId { get; set; }
        public Insurance Insurance { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string MemberId { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string GroupNumber { get; set; } = string.Empty;
        public DateOnly CoverageStartDate { get; set; }
        public DateOnly CoverageEndDate { get; set; }
        public int Priority { get; set; }
    }
}
