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
        mascotaEncontrada.Id = mascota.Id;
        mascotaEncontrada.Nombre = mascota.Nombre;
        mascotaEncontrada.Edad = mascota.Edad;
        mascotaEncontrada.Peso = mascota.Peso;
        mascotaEncontrada.Raza = mascota.Raza;
        mascotaEncontrada.Especie = mascota.Especie;
        mascotaEncontrada.Sexo = mascota.Sexo;
        //mascotaEncontrada.IdCuidador = mascota.IdCuidador;
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
      var mascota = this.appContext.Mascotas;
      foreach (var item in mascota){
        Console.WriteLine(item.Nombre);
      }
      return this.appContext.Mascotas;
    }

  }
}