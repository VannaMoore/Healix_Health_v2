using System.ComponentModel.DataAnnotations;
namespace HealixAPI.Models
{
    public class EncounterType
    {
        public int EncounterTypeId { get; set; }

        [Required]
        [MaxLength (50)]
        public string TypeName { get; set; } = string.Empty;
    }
}
