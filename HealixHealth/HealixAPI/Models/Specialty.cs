using System.ComponentModel.DataAnnotations;

namespace HealixAPI.Models
{
    public class Specialty
    {
        public int SpecialtyId { get; set; }

        [Required]
        [MaxLength (50)]
        public string SpecialtyName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string SpecialtyCode { get; set; } = string.Empty;

    }
}
