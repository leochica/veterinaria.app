using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia
{
  public class RepositorioMascota : IRepositorioMascota
  {
    private readonly AppContext appContext;

    public RepositorioMascota(AppContext appContext)
    {
      this.appContext = appContext;
    }

    // CRUD


    Mascota IRepositorioMascota.AgregarMascota(Mascota mascota)
    {
      var mascotaAgregada = this.appContext.Mascotas.Add(mascota);
      this.appContext.SaveChanges();
      return mascotaAgregada.Entity;
    }


    Mascota IRepositorioMascota.EditarMascota(Mascota mascota)
    {
      
      var mascotaEncontrada = this.appContext.Mascotas.FirstOrDefault(p => p.Id == mascota.Id);

      if (mascotaEncontrada != null)
      {
        //mascotaEncontrada.Id = mascota.Id; 
        mascotaEncontrada.Nombre = mascota.Nombre != null ? mascota.Nombre : mascotaEncontrada.Nombre;
        mascotaEncontrada.Edad = mascota.Edad != 0 ? mascota.Edad : mascotaEncontrada.Edad;
        mascotaEncontrada.Peso = mascota.Peso != 0 ? mascota.Peso : mascotaEncontrada.Peso;
        mascotaEncontrada.Raza = mascota.Raza != null ? mascota.Raza : mascotaEncontrada.Raza;
        mascotaEncontrada.Especie = mascota.Especie != null ? mascota.Especie : mascotaEncontrada.Especie;
        mascotaEncontrada.Sexo = mascota.Sexo != null ? mascota.Sexo : mascotaEncontrada.Sexo;
        mascotaEncontrada.IdCuidador = mascota.IdCuidador != null ? mascota.IdCuidador : mascotaEncontrada.IdCuidador;
        
        this.appContext.SaveChanges();  
        
        return mascotaEncontrada;
        
      }
      else
      {
        return null;
      }
    }


    Mascota IRepositorioMascota.ObtenerMascota(int idMascota)
    {
      return this.appContext.Mascotas.FirstOrDefault(p => p.Id == idMascota);
    }


    void IRepositorioMascota.EliminarMascota(int idMascota)
    {
      var mascotaEncontrada = this.appContext.Mascotas.FirstOrDefault(p => p.Id == idMascota);

      if (mascotaEncontrada != null)
      {
        this.appContext.Mascotas.Remove(mascotaEncontrada);
        this.appContext.SaveChanges();
      }
    }


    IEnumerable <Mascota> IRepositorioMascota.GetMascotas()
    {
      return this.appContext.Mascotas.AsNoTracking().ToList();
      //return this.appContext.Mascotas.ToList();
    }

  }
}