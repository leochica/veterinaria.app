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
    public class NuevoCuidadorModel : PageModel
    {
        private static IRepositorioCuidador repoCuidador = new RepositorioCuidador(new Persistencia.AppContext());
        [BindProperty]
        public modeloCuidador mCuidador { get; set;}
        [TempData]
        public string mensaje { get; set; } 
        public void OnGet(){}

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid){
                Console.WriteLine("Modelo no valido");
                return Page();                
            }

                       
            var nuevoCuidador = mCuidador.convertirAClase(mCuidador);
            nuevoCuidador.FechaRegistro = DateTime.Now;
            repoCuidador.AgregarCuidador(nuevoCuidador);
            mensaje = "Cuidador creado exitosamente";            
            return RedirectToPage("/Cuidador/Cuidador");
        }
    }
}
