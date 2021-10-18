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
    public class NuevaHistoriaModel : PageModel
    {
        private static IRepositorioHistoria repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioMascota repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioVeterinario repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        
        [TempData]
        public string mensaje { get; set; }  
        public int idMascota {get; set;}
        public int idCuidador {get; set;}
        public int idVeterinario {get; set;}
        [BindProperty]
        public Historia nuevaHistoria {get; set;}

        public IEnumerable<Veterinario> veterinario { get; set; }
        
        
        
        public void OnGet(int idMascota, int idCuidador)
        {
            this.idMascota = idMascota;
            this.idCuidador = idCuidador;

            veterinario = repoVeterinario.GetVeterinarios();
        }

        public ActionResult OnPost(int idCuidador, int idMascota)
        {
            Console.WriteLine("Entro al OnPost");
            nuevaHistoria.MascotaId = idMascota;
            repoHistoria.AgregarHistoria(nuevaHistoria);
            mensaje = "Historia Guardada con exito";
            return RedirectToPage("/AdminMascotas/AdminMascotas", new {idCuidador});
        }
    }
}
