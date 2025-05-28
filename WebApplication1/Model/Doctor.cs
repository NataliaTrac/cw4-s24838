namespace WebApplication1.Model;

public class Doctor
{
    public int IdDoctor { get; set; }
    public string FirstName { get; set; } // nvarchar(100)
    public string LastName { get; set; }  // nvarchar(100)
    public string Email { get; set; }     // nvarchar(100)

    public virtual ICollection<Prescription> Prescriptions { get; set; }
}
