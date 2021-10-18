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
    public class EditarHistoriaModel : PageModel
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
        public Historia editadaHistoria {get; set;}

        public IEnumerable<Veterinario> veterinario { get; set; }
        
        
        
        public void OnGet(int idCuidador, int idHistoria)
        {
           
            this.idCuidador = idCuidador;

            nuevaHistoria = repoHistoria.ObtenerHistoria(idHistoria);
            veterinario = repoVeterinario.GetVeterinarios();
        }

        public ActionResult OnPost(int idCuidador)
        {
            idMascota = nuevaHistoria.MascotaId;
            //Console.WriteLine(idMascota);
            repoHistoria.EditarHistoria(nuevaHistoria);
            mensaje = "Historia Editada con exito";
            return RedirectToPage("/AdminHistorias/Historia", new {idMascota, idCuidador});
        }
    }
}
