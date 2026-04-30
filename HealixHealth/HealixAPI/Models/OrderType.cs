using System.ComponentModel.DataAnnotations;
namespace HealixAPI.Models
{
    public class OrderType
    {
        public int OrderTypeId { get; set; }
        [Required]
        [MaxLength (50)]
        public string TypeName { get; set; } = string.Empty;
    }
}
