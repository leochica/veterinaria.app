using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
  public class AppContext : DbContext
  {
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Veterinario> Veterinarios { get; set; }
    public DbSet<Cuidador> Cuidadores { get; set; }
    public DbSet<Mascota> Mascotas { get; set; }
    public DbSet<Historia> Historias { get; set; }
    public DbSet<Cita> Citas { get; set; }
    public DbSet<PlanVacunacion> PlanesdeVacunacion { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        //optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BDVeterinariaGrupo26");
        optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=BDVeterinariaGrupo26; User ID=SA; Password=Abcd1234;");
      }     
    }

    /*protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<Mascota>().HasOne(c => c.IdCuidador).WithMany(m => m.Mascotas).IsRequired();
        }*/
  }
}
