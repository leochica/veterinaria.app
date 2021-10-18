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
    public class HistoriaModel : PageModel
    {
        private static RepositorioHistoria repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioMascota repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        public IEnumerable<Historia> historias { get; set; }
        public Historia historiaActual { get; set; }
        public Mascota mascotaActual { get; set; }

        [TempData]
        public string mensaje { get; set; }  

        public int idCuidador { get; set; }

        public void OnGet(int idMascota, int idCuidador)
        {
            if (idMascota == 0)
                {
                    RedirectToPage("/Cuidador/Cuidador");
                    
                }else
                {
                    this.idCuidador = idCuidador;
                    mascotaActual = repoMascota.ObtenerMascota(idMascota);
                    historias = repoHistoria.ObtenerHistoriaConIdMascota(idMascota);                                       
                }
        }

        public ActionResult OnPostEliminar(int idHistoria, int idCuidador)
        {
            if(idHistoria != 0)
            {
                repoHistoria.EliminarHistoria(idHistoria);
                mensaje = "Historia Eliminada";
                return RedirectToPage("/AdminMascotas/AdminMascotas", new {idCuidador});
            }else
            {
                return RedirectToPage();
            }
        }

    }
}
