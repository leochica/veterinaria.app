using System;



namespace Veterinaria.App.Dominio
{
  public class Mascota
  {
    public int Id { get; set; }
    
    public String Nombre { get; set; }
    public int Edad { get; set; }
    public int Peso { get; set; }
    public String Especie { get; set; }
    public String Raza { get; set; }
    public SexoAnimal Sexo { get; set; }
    public Cuidador IdCuidador { get; set; }
    /* Se comenta linea porque es redundate la clave ya que
       en historial esta vinculando id de mascota*/
    //public Historia IdHistoria { get; set; }
  }
}