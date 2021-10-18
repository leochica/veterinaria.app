using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{

  public interface IRepositorioHistoria
  {
    Historia AgregarHistoria(Historia historia);
    Historia EditarHistoria(Historia historia);
    Historia ObtenerHistoria(int idHistoria);
    
    IEnumerable<Historia> GetHistorias();
   
  }


}