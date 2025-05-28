using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model;

public class Prescription
{
    [Key]
    public int IdPrescription { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }

    public int IdPatient { get; set; }
    public virtual Patient Patient { get; set; }= null!;

    public int IdDoctor { get; set; }
    public virtual Doctor Doctor { get; set; }= null!;

    public virtual ICollection<Prescription_Medicament> PrescriptionMedicaments { get; set; }= null!;
}
