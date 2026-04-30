using System.ComponentModel.DataAnnotations;

namespace HealixAPI.Models
{
    public class Insurance
    {
        public int InsuranceId { get; set; }
        [Required]
        [MaxLength (50)]
        public string PayerName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string PlanType { get; set; } = string.Empty;
    }
}
