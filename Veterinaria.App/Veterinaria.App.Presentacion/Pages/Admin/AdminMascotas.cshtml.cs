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
        public IEnumerable<Mascota> listaMascotas;
        public Mascota mascotaActual;
        public String modeForm { get; set; } = "adicion";

        public void OnGet(int idMascota)
        {
            if (idMascota != 0)
            {
                mascotaActual = repoMascota.ObtenerMascota(idMascota);
                modeForm = this.mascotaActual!= null ? "edicion" : "adicion";
            }
            this.listaMascotas = repoMascota.GetMascotas();
        }

        public void OnPostEditar(Mascota mascota){
            Console.WriteLine("Este es el nombre " + mascota.Id);
            var mascotaModificada = repoMascota.EditarMascota(mascota);
            if(mascotaModificada != null){
                this.listaMascotas = repoMascota.GetMascotas();
                Console.WriteLine("La mascota a sido editada");
            }else{
                Console.Write("Ocurrio un error al editar la mascota");
            }
        }
        public void OnPostAdicionar(Mascota mascota){
            repoMascota.AgregarMascota(mascota);
            Console.WriteLine(mascota.IdCuidador);
            this.listaMascotas = repoMascota.GetMascotas();
        }
        public void OnPostEliminar(int idMascota)
        {
            if (idMascota != 0)
            {
                repoMascota.EliminarMascota(idMascota);
                this.listaMascotas = repoMascota.GetMascotas();
                Console.WriteLine("Mascota Eliminada");
            }
            else
            {
                Console.WriteLine("Error al elimnar mascota");
            }
        }
    }
}
