using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model;

public class Prescription_Medicament
{
    [Key]
    public int IdMedicament { get; set; }

    public virtual Medicament Medicament { get; set; } = null!;
    [Key]
    public int IdPrescription { get; set; }
    public virtual Prescription Prescription { get; set; }= null!;

    public int? Dose { get; set; }
    public string Details { get; set; } = null!;// nvarchar(100)
}
