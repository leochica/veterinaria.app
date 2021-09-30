using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia
{
  public class RepositorioCita : IRepositorioCita
  {
    private readonly AppContext appContext;

    public RepositorioCita(AppContext appContext)
    {
      this.appContext = appContext;
    }

    // CRUD


    Cita IRepositorioCita.AgregarCita(Cita cita)
    {
      var citaAgregada = this.appContext.Citas.Add(cita);
      this.appContext.SaveChanges();
      return citaAgregada.Entity;
    }


    Cita IRepositorioCita.EditarCita(Cita cita)
    {
      var citaEncontrada = this.appContext.Citas.FirstOrDefault(p => p.Id == cita.Id);

      if (citaEncontrada != null)
      {
        citaEncontrada.Id = cita.Id;
        citaEncontrada.Fecha = cita.Fecha;
        citaEncontrada.TipoConsulta = cita.TipoConsulta;
        citaEncontrada.IdVeterinario = cita.IdVeterinario;
        this.appContext.SaveChanges();
        return citaEncontrada;
      }
      else
      {
        return null;
      }
    }


    Cita IRepositorioCita.ObtenerCita(int idCita)
    {
      return this.appContext.Citas.FirstOrDefault(p => p.Id == idCita);
    }


    void IRepositorioCita.EliminarCita(int idCita)
    {
      var citaEncontrada = this.appContext.Citas.FirstOrDefault(p => p.Id == idCita);

      if (citaEncontrada != null)
      {
        this.appContext.Citas.Remove(citaEncontrada);
        this.appContext.SaveChanges();
      }
    }


    IEnumerable<Cita> IRepositorioCita.GetCitas()
    {
      return null;
    }


  }
}