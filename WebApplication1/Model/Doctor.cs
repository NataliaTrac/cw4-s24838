using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model;

[Table("Doctor")]
public class Doctor
{
    [Key]
    public int IdDoctor { get; set; }
    
    [MaxLength(100)]
    public string FirstName { get; set; }= null!; // nvarchar(100)
    [MaxLength(100)]
    public string LastName { get; set; } = null!; // nvarchar(100)
    [MaxLength(100)]
    public string Email { get; set; }  = null!;   // nvarchar(100)

    public virtual ICollection<Prescription> Prescriptions { get; set; }
}
