using System.ComponentModel.DataAnnotations;

namespace HealixAPI.Models
{
    public class ClinicalStaff
    {
        public Guid ClinicalStaffId { get; set; }
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string EmployeeId { get; set; } = string.Empty;
        public int PositionId { get; set; }
        public Position Position { get; set; } = null!;
    }
}
