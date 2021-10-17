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
        private static IRepositorioCuidador repoCuidador = new RepositorioCuidador(new Persistencia.AppContext());

        [BindProperty]
        public modeloMascota mMascota { get; set; }

        [TempData]
        public int idCuidador { get; set; }

        public Cuidador cuidador { get; set; }
        
        [TempData]
        public string mensaje { get; set; } 
        

        public void OnGet(int id){
            
            this.idCuidador = id;
            
        }

        public ActionResult OnPost(int id){
            idCuidador = id;
            
            if(!ModelState.IsValid){
                Console.WriteLine("Modelo Nueva Mascota no valido");
                return Page();                
            }
            
            //Convierte de modelo a clase    
            var nuevaMascota = mMascota.convertirModelo(mMascota);
            
            //Crear la mascola en la DB sin cuidadorActual
            var mascotaAgregada = repoMascota.AgregarMascota(nuevaMascota);
            
            //Consulta el cuidador asignar el cuidador a la mascota
            cuidador = repoCuidador.ObtenerCuidador(idCuidador);
            mascotaAgregada.IdCuidador = cuidador;

            //Actualiza la mascota con el cuidadorActual
            repoMascota.EditarMascota(mascotaAgregada);           
            
            mensaje = "Mascota creada exitosamente";
                       
            return RedirectToPage("/AdminMascotas/AdminMascotas", new {idCuidador});

        }
        
       
    }
}
