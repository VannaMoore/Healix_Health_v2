// Purely a junction table
namespace HealixAPI.Models
{
    public class ProviderSpecialty
    {
        public Guid ProviderId { get; set; } // composite key
        public Provider Provider { get; set; } = null!; // navigational propety
        public int SpecialtyId { get; set; } // composit key
        public Specialty Specialty { get; set; } = null!; // navigational property

    }
}
