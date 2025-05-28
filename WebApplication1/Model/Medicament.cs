namespace WebApplication1.Model;

public class Medicament
{
    public int IdMedicament { get; set; }
    public string Name { get; set; }        // nvarchar(100)
    public string Description { get; set; } // nvarchar(100)
    public string Type { get; set; }        // nvarchar(100)

    public virtual ICollection<Prescription_Medicament> Prescription_Medicaments { get; set; }
}
