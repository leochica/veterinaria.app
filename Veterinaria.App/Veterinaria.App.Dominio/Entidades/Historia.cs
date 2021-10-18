using System;

namespace Veterinaria.App.Dominio
{
  public class Historia
  {
    public int Id { get; set; }
    public DateTime FechaConsulta { get; set; }
    public int MascotaId { get; set; }
    public Consulta TipoConsulta { get; set; }
    public String Diagnostico { get; set; }
    
  }
}