using System.ComponentModel.DataAnnotations;

namespace HealixAPI.Models
{
    public class Prescription
    {
        public Guid PrescriptionId { get; set; }

        public Guid ProviderId { get; set; }
        public Provider Provider { get; set; } = null!;
       
        public Guid EncounterId { get; set; }
        public Encounter Encounter { get; set; } = null!;

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string DrugName { get; set; } = string.Empty;

        [Required]
        [MaxLength(13)]
        public string NDC { get; set; } = string.Empty; // 11 digit identifier

        [Required]
        [MaxLength(50)]
        public string Dosage { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Frequency { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public int Refills { get; set; }
        public DateOnly PrescriptionDate { get; set; }
    }
}
