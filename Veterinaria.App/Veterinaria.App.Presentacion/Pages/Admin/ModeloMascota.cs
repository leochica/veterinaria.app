using System;
using System.ComponentModel.DataAnnotations;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Presentacion.Pages
{

    public class modeloMascota
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Ingrese el nombre de la mascota")]
        [Display(Name = "Nombre:")]
        public String Nombre { get; set; }
        
        [Required(ErrorMessage = "Ingrese la edad de la mascota")]
        [Display(Name = "Edad:")]
        public int Edad { get; set; }
        
        [Required(ErrorMessage = "Ingrese el peso de la mascota")]
        [Display(Name = "Peso(Kg):")]
        public int Peso { get; set; }
        
        [Required(ErrorMessage = "Ingrese la especie de la mascota")]
        [Display(Name = "Especie:")]
        public String Especie { get; set; }
        
        [Display(Name = "Raza:")]
        public String Raza { get; set; }
        
        [Display(Name = "Sexo:")]
        public SexoAnimal Sexo { get; set; }
        
        /*
        [Required(ErrorMessage = "Ingrese el ID del cuidador")]
        [Display(Name = "Identificación Cuidador:")]
        public Cuidador IdCuidador { get; set; }*/

        public Mascota convertirModelo (modeloMascota mMascota){
            Mascota nuevaMascota = new Mascota{
                Id = mMascota.Id,
                Nombre = mMascota.Nombre,
                Edad = mMascota.Edad,
                Peso = mMascota.Peso,
                Especie = mMascota.Especie,
                Raza = mMascota.Raza,
                Sexo = mMascota.Sexo,
                //IdCuidador = mMascota.IdCuidador
            };
            return nuevaMascota;
        }
    }
}