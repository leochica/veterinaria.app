using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;
using System.Text.Json;

namespace Veterinaria.App.Presentacion.Pages
{
    public class AdminMascotasModel : PageModel
    {
        private static IRepositorioMascota repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioCuidador repoCuidador = new RepositorioCuidador(new Persistencia.AppContext());
        public IEnumerable<Mascota> listaMascotas { get; set;}

        public Cuidador cuidadorActual;

        [TempData]
        public int idCuidador { get; set; } 

        [TempData]
        public string mensaje { get; set; }  
        

        public void OnGet(int idCuidador)
        {
            if (idCuidador == 0)
                {
                    RedirectToPage("/Cuidador/Cuidador");
                    
                }else
                {
                    cuidadorActual = (Cuidador)repoCuidador.ObtenerConMascotas(idCuidador);                    
                }
                   
        }

        public ActionResult OnPostEliminar(int idMascota, int idCuidador)
        {
            if (idMascota != 0)
            {
                repoMascota.EliminarMascota(idMascota);
                mensaje = "Mascota eliminada correctamente";            
                return RedirectToPage("/AdminMascotas/AdminMascotas", new { idCuidador = idCuidador});
            }
            else
            {
                return RedirectToPage();
            }
        }

        public void OnPostEdit(int id, int idMascota)
        {
           if (idMascota != 0)
            {               
                //Response.Redirect("/AdminMascotas/Edit/");
                
            }
            else
            {
                
            }
            
        }
    }
}
