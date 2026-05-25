// Junction table to many-to-many relationship between patient and provider
namespace HealixAPI.Models
{
    public class PatientProvider
    {
        public Guid PatientId { get; set; } // composite primary key
        public Patient Patient { get; set; } = null!;
        public Guid ProviderId { get; set; } // composite primary key
        public Provider Provider { get; set; } = null!;
        public DateOnly AssignedDate { get; set; }
    }
}
