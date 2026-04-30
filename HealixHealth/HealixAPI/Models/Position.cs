using System.ComponentModel.DataAnnotations;
namespace HealixAPI.Models
{
    public class Position
    {
        [Required]
        [MaxLength(50)]
        public int PositionId { get; set; }
        public string PositionName { get; set; } = string.Empty;
    }
}
