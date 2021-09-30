using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{

  public interface IRepositorioCuidador
  {
    Cuidador AgregarCuidador(Cuidador cuidador);
    Cuidador EditarCuidador(Cuidador cuidador);
    Cuidador ObtenerCuidador(int idCuidador);
    void EliminarCuidador(int idCuidador);
    IEnumerable<Cuidador> GetCuidadores();
  }


}