using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model;

public class Patient
{
    [Key]
    public int IdPatient { get; set; }
    [MaxLength(100)]
    public string FirstName { get; set; }= null!; // nvarchar(100)
    [MaxLength(100)]
    public string LastName { get; set; } = null!; // nvarchar(100)
    public DateTime Birthdate { get; set; }

    public virtual ICollection<Prescription> Prescriptions { get; set; }= null!;
}
