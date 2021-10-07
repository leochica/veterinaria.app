using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Veterinaria.App.Persistencia
{
  public class RepositorioPlanVacunacion : IRepositorioPlanVacunacion
  {
    private readonly AppContext appContext;
		
    public RepositorioPlanVacunacion(AppContext appContextParam)
    {
      this.appContext = appContextParam;
    }
    //CRUD

    PlanVacunacion IRepositorioPlanVacunacion.AgregarPlanVacunacion(PlanVacunacion PlanVacunacion)
    {
      var PlanVacunacionAgregado = this.appContext.PlanesdeVacunacion.Add(PlanVacunacion);
      this.appContext.SaveChanges();

      return PlanVacunacionAgregado.Entity;
    }

    PlanVacunacion IRepositorioPlanVacunacion.EditarPlanVacunacion(PlanVacunacion PlanVacunacionNuevo)
    {
      var PlanVacunacionEncontrado = this.appContext.PlanesdeVacunacion.FirstOrDefault(PV => PV.Id == PlanVacunacionNuevo.Id);
      if (PlanVacunacionEncontrado != null)
      {
        PlanVacunacionEncontrado.NombreVacuna = PlanVacunacionNuevo.NombreVacuna;
        PlanVacunacionEncontrado.FechaVacuna = PlanVacunacionNuevo.FechaVacuna;
        this.appContext.SaveChanges();
        return PlanVacunacionEncontrado;
      }
      else
      {
        return null;
      }

    }

    void IRepositorioPlanVacunacion.EliminarPlanVacunacion(int IdPlanVacunacion)
    {
      var PlanVacunacionEncontrado = this.appContext.PlanesdeVacunacion.FirstOrDefault(PV => PV.Id == IdPlanVacunacion);

      if (PlanVacunacionEncontrado != null)
      {
        this.appContext.PlanesdeVacunacion.Remove(PlanVacunacionEncontrado);
        this.appContext.SaveChanges();
      }
    }

    PlanVacunacion IRepositorioPlanVacunacion.GetPlanVacunacion(int IdPlanVacunacion)
    {
      return this.appContext.PlanesdeVacunacion.FirstOrDefault(PV => PV.Id == IdPlanVacunacion);
    }

    IEnumerable<PlanVacunacion> IRepositorioPlanVacunacion.GetPlanesdeVacunacion()
    {
      return null;
    }
  }
}
