using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia
{
  public class RepositorioCuidador : IRepositorioCuidador
  {
    private readonly AppContext appContext;

    public RepositorioCuidador(AppContext appContext)
    {
      this.appContext = appContext;
    }

    // CRUD


    Cuidador IRepositorioCuidador.AgregarCuidador(Cuidador cuidador)
    {
      var cuidadorAgregado = this.appContext.Cuidadores.Add(cuidador);
      this.appContext.SaveChanges();
      return cuidadorAgregado.Entity;
    }


    Cuidador IRepositorioCuidador.EditarCuidador(Cuidador cuidador)
    {
      var cuidadorEncontrado = this.appContext.Cuidadores.FirstOrDefault(p => p.Id == cuidador.Id);

      if (cuidadorEncontrado != null)
      {
        cuidadorEncontrado.Id = cuidador.Id;
        cuidadorEncontrado.Nombres = cuidador.Nombres;
        cuidadorEncontrado.Apellidos = cuidador.Apellidos;
        cuidadorEncontrado.Edad = cuidador.Edad;
        cuidadorEncontrado.Genero = cuidador.Genero;
        cuidadorEncontrado.Telefono = cuidador.Telefono;
        cuidadorEncontrado.Direccion = cuidador.Direccion;
        cuidadorEncontrado.Correo = cuidador.Correo;
        cuidadorEncontrado.Contrasenia = cuidador.Contrasenia;
        this.appContext.SaveChanges();
        return cuidadorEncontrado;
      }
      else
      {
        return null;
      }
    }


    Cuidador IRepositorioCuidador.ObtenerCuidador(int idCuidador)
    {
      return this.appContext.Cuidadores.FirstOrDefault(p => p.Id == idCuidador);
    }


    void IRepositorioCuidador.EliminarCuidador(int idCuidador)
    {
      var cuidadorEncontrado = this.appContext.Cuidadores.FirstOrDefault(p => p.Id == idCuidador);

      if (cuidadorEncontrado != null)
      {
        this.appContext.Cuidadores.Remove(cuidadorEncontrado);
        this.appContext.SaveChanges();
      }
    }


    IEnumerable<Cuidador> IRepositorioCuidador.GetCuidadores()
    {
      return this.appContext.Cuidadores.AsNoTracking();
    }

    Object IRepositorioCuidador.ObtenerConMascotas(int idObjeto){
        
            var objetoEncontrado = this.appContext.Cuidadores.AsNoTracking().Include("Mascotas").FirstOrDefault(p => p.Id == idObjeto);
            return objetoEncontrado;
        }

  }
}