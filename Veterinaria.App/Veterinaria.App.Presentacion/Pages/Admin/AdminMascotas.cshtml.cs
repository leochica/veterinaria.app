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
    public class AdminMascotasModel : PageModel
    {
        private static IRepositorioMascota repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static RepositorioCuidador repoCuidador = new RepositorioCuidador(new Persistencia.AppContext());
        public IEnumerable<Mascota> listaMascotas { get; set;}
        [TempData]
        public string mensaje { get; set; }  
        
        public void OnGet(int id)
        {
            if (id == 0)
            {
                listaMascotas = repoMascota.GetMascotas(); 
            }else
            {
                //listaMascotas = repoCuidador.GetCuidadorConMascotas(id);
            }           
        }

        public ActionResult OnPostEliminar(int id)
        {
            if (id != 0)
            {
                repoMascota.EliminarMascota(id);
                mensaje = "Mascota eliminada correctamente";
                return RedirectToPage("/Admin/AdminMascotas");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
