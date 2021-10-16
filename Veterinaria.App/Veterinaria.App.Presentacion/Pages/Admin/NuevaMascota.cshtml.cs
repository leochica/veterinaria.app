using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;


namespace Veterinaria.App.Presentacion.Pages
{
    public class NuevaMascotaModel : PageModel
    {
        private static IRepositorioMascota repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        [BindProperty]
        public modeloMascota mMascota { get; set; }
        
        [TempData]
        public string mensaje { get; set; } 
        
        public void OnGet(){}

        public ActionResult OnPost(){
            if(!ModelState.IsValid){
                Console.WriteLine("Modelo Nueva Mascota no valido");
                return Page();
                
            }
                        
            var nuevaMascota = mMascota.convertirModelo(mMascota);

            repoMascota.AgregarMascota(nuevaMascota);
            mensaje = "Mascota creada exitosamente";            
            return RedirectToPage("/Admin/AdminMascotas");

        }
        
       
    }
}
