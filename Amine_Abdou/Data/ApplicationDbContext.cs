using Amine_Abdou.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Amine_Abdou.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            // Ajoute tes DbSet ici
            public DbSet<Medecin> medecins { get; set; }
            public DbSet<Patient> Patients { get; set; }
            public DbSet<Maladie> Maladies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aucune configuration de relation nécessaire
        }
    }
    
}
