using System;
using System.ComponentModel.DataAnnotations;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Presentacion.Pages
{
    public class modeloCuidador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese los nombre del cuidador")]
        [Display(Name = "Nombres")]        
        public String Nombres { get; set; }
        
        [Required(ErrorMessage = "Ingrese los apellidos del cuidador")]
        [Display(Name = "Apellidos")]
        public String Apellidos { get; set; }
        
        [Display(Name = "Edad")]
        public int Edad { get; set; }
        
        [Display(Name = "Genero")]
        public Genero Genero { get; set; }
        
        [Display(Name = "Telefono")]
        public String Telefono { get; set; }
        
        [Display(Name = "Dirección")]
        public String Direccion { get; set; }
        
        [Required(ErrorMessage = "Ingrese un email valido")]
        [EmailAddress]
        [Display(Name = "Email")]
        public String Correo { get; set; }
        
        [Required(ErrorMessage = "Ingrese una contraseña")]
        [Display(Name = "Contraseña")]
        public String Contrasenia { get; set; }
        
        public DateTime FechaRegistro { get; set; }
        
        //public Perfil TipoPerfil { get; set; }

        public Cuidador convertirAClase(modeloCuidador m){
            Cuidador nuevoCuidador = new Cuidador{
                Id = m.Id,
                Nombres = m.Nombres,
                Apellidos = m.Apellidos,
                Edad = m.Edad,
                Genero = m.Genero,
                Telefono = m.Telefono,
                Direccion = m.Direccion,
                Correo = m.Correo,
                Contrasenia = m.Contrasenia,
                FechaRegistro = m.FechaRegistro,
                //TipoPerfil = m.TipoPerfil
            };
            return nuevoCuidador;
        }

        
    }
}