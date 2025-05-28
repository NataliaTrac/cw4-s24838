using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }
    
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Prescription_Medicament> PrescriptionMedicaments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Patient>(e =>
        {
            e.HasKey(p => p.IdPatient);
            e.Property(p => p.FirstName).IsRequired().HasMaxLength(100);
            e.Property(p => p.LastName).IsRequired().HasMaxLength(100);
            e.Property(p => p.Birthdate).IsRequired();
        });
        
        modelBuilder.Entity<Doctor>(e =>
        {
            e.HasKey(d => d.IdDoctor);
            e.Property(d => d.FirstName).IsRequired().HasMaxLength(100);
            e.Property(d => d.LastName).IsRequired().HasMaxLength(100);
            e.Property(d => d.Email).IsRequired().HasMaxLength(100);
        });

        modelBuilder.Entity<Medicament>(e =>
        {
            e.HasKey(m => m.IdMedicament);
            e.Property(m => m.Name).IsRequired().HasMaxLength(100);
            e.Property(m => m.Description).IsRequired().HasMaxLength(100);
            e.Property(m => m.Type).IsRequired().HasMaxLength(100);
        });

        modelBuilder.Entity<Prescription>(e =>
        {
            e.HasKey(p => p.IdPrescription);
            e.Property(p => p.Date).IsRequired();
            e.Property(p => p.DueDate).IsRequired();

            e.HasOne(p => p.Patient)
                .WithMany(pat => pat.Prescriptions)
                .HasForeignKey(p => p.IdPatient);

            e.HasOne(p => p.Doctor)
                .WithMany(doc => doc.Prescriptions)
                .HasForeignKey(p => p.IdDoctor);
        });

        modelBuilder.Entity<Prescription_Medicament>(e =>
        {
            e.HasKey(pm => new { pm.IdMedicament, pm.IdPrescription }); // Composite PK

            e.HasOne(pm => pm.Medicament)
                .WithMany(m => m.Prescription_Medicaments)
                .HasForeignKey(pm => pm.IdMedicament);

            e.HasOne(pm => pm.Prescription)
                .WithMany(p => p.PrescriptionMedicaments)
                .HasForeignKey(pm => pm.IdPrescription);

            e.Property(pm => pm.Details).IsRequired().HasMaxLength(100);
            
            
        });

    }
}