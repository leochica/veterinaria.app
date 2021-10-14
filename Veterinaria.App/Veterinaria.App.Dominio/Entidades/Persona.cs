using System;


namespace Veterinaria.App.Dominio
{
  public class Persona
  {
    public int Id { get; set; }
    public String Nombres { get; set; }
    public String Apellidos { get; set; }
    public int Edad { get; set; }
    public Genero Genero { get; set; }
    public String Telefono { get; set; }
    public String Direccion { get; set; }
    public String Correo { get; set; }
    public String Contrasenia { get; set; }
    public DateTime FechaRegistro { get; set; }
    public Perfil TipoPerfil { get; set; }
  }
}