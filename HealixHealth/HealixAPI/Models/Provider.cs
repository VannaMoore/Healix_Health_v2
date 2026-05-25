using System.ComponentModel.DataAnnotations;

namespace HealixAPI.Models
{
    public class Provider
    {
        public Guid ProviderId { get; set; }

        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string NPI { get; set; } = string.Empty;

        public int ProviderTypeId { get; set; }

        public ProviderType ProviderType { get; set; } = null!;


    }
}