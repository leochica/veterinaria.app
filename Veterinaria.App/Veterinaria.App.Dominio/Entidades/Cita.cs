using System;

namespace Veterinaria.App.Dominio
{
  public class Cita
  {
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public Consulta TipoConsulta { get; set; }
    public Mascota IdMascota { get; set; }
    public Cuidador IdCuidador { get; set; }
    public Veterinario IdVeterinario { get; set; }
  }
}