using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Presentacion.Pages
{
    public class EditarCuidadorModel : PageModel
    {
        private static IRepositorioCuidador repoCuidador = new RepositorioCuidador(new Persistencia.AppContext());
        [BindProperty]
        public modeloCuidador mCuidador { get; set;}
        public modeloCuidador moCuidador { get; set;}
        public Cuidador cuidador { get; set; }
        
        [TempData]
        public string mensaje { get; set; } 
        
        public void OnGet(int id)
        {
            
            if(id == 0){
                Console.WriteLine("ID no valido");                               
            }

            cuidador = repoCuidador.ObtenerCuidador(id);
            
            mCuidador = convertirAModelo(cuidador);
            Console.WriteLine("Nombre "+mCuidador.Nombres);
        }

        public modeloCuidador convertirAModelo(Cuidador m){
            Console.WriteLine("Bien "+m.Nombres);
            modeloCuidador nuevoCuidador = new modeloCuidador{
                
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

        public ActionResult OnPost(int id)
        {
            Console.WriteLine(ModelState.IsValid +" "+id);
            if(ModelState.IsValid)
            {
                var cuidadorModificado = mCuidador.convertirAClase(mCuidador);
                repoCuidador.EditarCuidador(cuidadorModificado);
                mensaje = "Cuidador editado exitosamente";            
                return RedirectToPage("/Cuidador/Cuidador");
            }

            return Page();

                       
            
        }
    }
}
