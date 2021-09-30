using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia
{
  public class RepositorioVeterinario : IRepositorioVeterinario
  {
    private readonly AppContext appContext;

    public RepositorioVeterinario(AppContext appContext)
    {
      this.appContext = appContext;
    }

    // CRUD


    Veterinario IRepositorioVeterinario.AgregarVeterinario(Veterinario veterinario)
    {
      var veterinarioAgregado = this.appContext.Veterinarios.Add(veterinario);
      this.appContext.SaveChanges();
      return veterinarioAgregado.Entity;
    }


    Veterinario IRepositorioVeterinario.EditarVeterinario(Veterinario veterinario)
    {
      var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(p => p.Id == veterinario.Id);

      if (veterinarioEncontrado != null)
      {
        veterinarioEncontrado.Id = veterinario.Id;
        veterinarioEncontrado.Nombres = veterinario.Nombres;
        veterinarioEncontrado.Apellidos = veterinario.Apellidos;
        veterinarioEncontrado.Edad = veterinario.Edad;
        veterinarioEncontrado.Genero = veterinario.Genero;
        veterinarioEncontrado.Telefono = veterinario.Telefono;
        veterinarioEncontrado.Direccion = veterinario.Direccion;
        veterinarioEncontrado.Correo = veterinario.Correo;
        veterinarioEncontrado.Especialidad = veterinario.Especialidad;
        this.appContext.SaveChanges();
        return veterinarioEncontrado;
      }
      else
      {
        return null;
      }
    }


    Veterinario IRepositorioVeterinario.ObtenerVeterinario(int idVeterinario)
    {
      return this.appContext.Veterinarios.FirstOrDefault(p => p.Id == idVeterinario);
    }


    void IRepositorioVeterinario.EliminarVeterinario(int idVeterinario)
    {
      var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(p => p.Id == idVeterinario);

      if (veterinarioEncontrado != null)
      {
        this.appContext.Veterinarios.Remove(veterinarioEncontrado);
        this.appContext.SaveChanges();
      }
    }


    IEnumerable<Veterinario> IRepositorioVeterinario.GetVeterinarios()
    {
      return null;
    }


  }
}