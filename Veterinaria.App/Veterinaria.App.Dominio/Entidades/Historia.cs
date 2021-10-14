using System;

namespace Veterinaria.App.Dominio
{
  public class Historia
  {
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public Mascota IdMascota { get; set; }
    //public Mascota NombreMascota { get; set; }
    //public Cuidador NombreCuidador { get; set; }
    public Cita DatosCitas { get; set; }
    public String Diagnostico { get; set; }
    public String CarnetVacunacion { get; set; }
  }
}