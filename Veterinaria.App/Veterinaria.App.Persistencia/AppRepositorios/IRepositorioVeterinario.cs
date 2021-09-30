using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{

  public interface IRepositorioVeterinario
  {
    Veterinario AgregarVeterinario(Veterinario veterinario);
    Veterinario EditarVeterinario(Veterinario veterinario);
    Veterinario ObtenerVeterinario(int idVeterinario);
    void EliminarVeterinario(int idVeterinario);
    IEnumerable<Veterinario> GetVeterinarios();
  }


}