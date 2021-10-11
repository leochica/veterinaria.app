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
        public IEnumerable<Mascota> listaMascotas { get; set;}
        [TempData]
        public string mensaje { get; set; }  
        public void OnGet()
        {
            this.listaMascotas = repoMascota.GetMascotas();
            Console.WriteLine("-------------------------");
            //foreach (var item in listaMascotas){
            //    
            //    Console.WriteLine(item.Nombre);
            //}
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
