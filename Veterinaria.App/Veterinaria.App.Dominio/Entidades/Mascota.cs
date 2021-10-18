using System;
using System.Collections.Generic;



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
    public List<Historia> Historia { get; set; }
  }
}