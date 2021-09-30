using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia
{
  public class RepositorioHistoria : IRepositorioHistoria
  {
    private readonly AppContext appContext;

    public RepositorioHistoria(AppContext appContext)
    {
      this.appContext = appContext;
    }

    // CRUD


    Historia IRepositorioHistoria.AgregarHistoria(Historia historia)
    {
      var historiaAgregada = this.appContext.Historias.Add(historia);
      this.appContext.SaveChanges();
      return historiaAgregada.Entity;
    }


    Historia IRepositorioHistoria.EditarHistoria(Historia historia)
    {
      var historiaEncontrada = this.appContext.Historias.FirstOrDefault(p => p.Id == historia.Id);

      if (historiaEncontrada != null)
      {
        historiaEncontrada.Id = historia.Id;
        historiaEncontrada.DatosCitas = historia.DatosCitas;
        historiaEncontrada.Diagnostico = historia.Diagnostico;
        this.appContext.SaveChanges();
        return historiaEncontrada;
      }
      else
      {
        return null;
      }
    }


    Historia IRepositorioHistoria.ObtenerHistoria(int idHistoria)
    {
      return this.appContext.Historias.FirstOrDefault(p => p.Id == idHistoria);
    }


    void IRepositorioHistoria.EliminarHistoria(int idHistoria)
    {
      var historiaEncontrada = this.appContext.Historias.FirstOrDefault(p => p.Id == idHistoria);

      if (historiaEncontrada != null)
      {
        this.appContext.Historias.Remove(historiaEncontrada);
        this.appContext.SaveChanges();
      }
    }


    IEnumerable<Historia> IRepositorioHistoria.GetHistorias()
    {
      return null;
    }


  }
}