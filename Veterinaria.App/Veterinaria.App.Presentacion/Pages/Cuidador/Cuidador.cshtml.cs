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
    public class CuidadorModel : PageModel
    {
        private static IRepositorioCuidador repoCuidador = new RepositorioCuidador(new Persistencia.AppContext());
        public IEnumerable<Cuidador> listaCuidadores { get; set;}
        [TempData]
        public string mensaje { get; set; } 
        
        public void OnGet()
        {
            listaCuidadores = repoCuidador.GetCuidadores();
        }

        public ActionResult OnPostEliminar(int id)
        {
            if (id != 0)
            {
                repoCuidador.EliminarCuidador(id);
                mensaje = "Cuidador eliminado correctamente";
                return RedirectToPage("/Cuidador/cuidador");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
