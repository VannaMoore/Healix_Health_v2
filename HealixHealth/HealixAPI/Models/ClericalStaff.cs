using System.ComponentModel.DataAnnotations;
namespace HealixAPI.Models
{
    public class ClericalStaff
    {
        public Guid ClericalStaffId { get; set; }

        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string EmployeeId { get; set; } = string.Empty;
    }
}
