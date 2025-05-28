using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model;

[Table("Medicament")]
public class Medicament
{
    [Key]
    public int IdMedicament { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = null!;       // nvarchar(100)
    [MaxLength(100)]
    public string Description { get; set; }= null!; // nvarchar(100)
    [MaxLength(100)]
    public string Type { get; set; } = null!;       // nvarchar(100)

    public virtual ICollection<Prescription_Medicament> Prescription_Medicaments { get; set; }
}
