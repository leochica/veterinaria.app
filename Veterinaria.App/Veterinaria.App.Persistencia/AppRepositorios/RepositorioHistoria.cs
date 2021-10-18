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
        historiaEncontrada.FechaConsulta = historia.FechaConsulta == null ? historiaEncontrada.FechaConsulta : historia.FechaConsulta;
        historiaEncontrada.MascotaId = historia.MascotaId == null ? historiaEncontrada.MascotaId : historia.MascotaId;
        historiaEncontrada.VeterinarioId = historia.VeterinarioId == null ? historiaEncontrada.VeterinarioId : historia.VeterinarioId;
        historiaEncontrada.TipoConsulta = historia.TipoConsulta == null ? historiaEncontrada.TipoConsulta : historia.TipoConsulta;
        historiaEncontrada.Diagnostico = historia.Diagnostico == null ? historiaEncontrada.Diagnostico : historia.Diagnostico;
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


    public void EliminarHistoria(int idHistoria)
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
      return this.appContext.Historias.AsNoTracking();
    }

    public IEnumerable<Historia> ObtenerHistoriaConIdMascota(int idObjeto)
    {
      var objetoEncontrado = this.appContext.Historias.Where(x => x.MascotaId == idObjeto).AsNoTracking();
      return objetoEncontrado;
      //return null;
    }


  }
}