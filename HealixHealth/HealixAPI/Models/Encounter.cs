using System.ComponentModel.DataAnnotations;

namespace HealixAPI.Models
{
    public class Encounter
    {
        public Guid EncounterId { get; set; }
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; } = null!;
        public Guid ProviderId { get; set; }
        public Provider Provider { get; set; } = null!;
        public int EncounterTypeId { get; set; }
        public EncounterType EncounterType { get; set; } = null!;
        public DateTime EncounterDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string ReasonForVisit { get; set; } = string.Empty;

        [Required]
        [MaxLength(3000)]
        public string HpiNotes { get; set; } = string.Empty;

        [Required]
        [MaxLength(3000)]
        public string CarePlan { get; set; } = string.Empty;

    }
}
