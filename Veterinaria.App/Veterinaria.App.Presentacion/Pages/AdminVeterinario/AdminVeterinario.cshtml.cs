using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Presentacion.Pages
{
    public class AdminVeterinarioModel : PageModel
    {

        private static IRepositorioVeterinario repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        public String titulo = "Administración de Veterinarios";

        // public List<Veterinario> listaVeterinarios = new List<Veterinario>();

        public IEnumerable<Veterinario> listaVeterinarios;

        public Veterinario veterinarioActual;

        public String modeForm { get; set; } = "adicion";


        public void OnGet(int id)
        {
            if (id != 0)
            {
                this.veterinarioActual = repoVeterinario.ObtenerVeterinario(id);
                if (this.veterinarioActual != null)
                {
                    this.modeForm = "edicion";
                }
            }
            else
            {
                this.listaVeterinarios = repoVeterinario.GetVeterinarios();
            }
        }

        

        public void OnPostEdit(Veterinario veterinario)
        {
            Boolean succes = this.EditarVeterinario(veterinario);
            if (succes == true)
            {
                Console.WriteLine("Cambios realizados con exito");
            }
            else
            {
                Console.WriteLine("Ocurrió un error, verifique");
            }
        }

        public Boolean EditarVeterinario(Veterinario veterinario)
        {
            var veterinarioEditado = repoVeterinario.EditarVeterinario(veterinario);
            if (veterinarioEditado != null)
            {
                this.listaVeterinarios = repoVeterinario.GetVeterinarios();
                return true;
            }
            else
            {
                return false;
            }
        }


        public void OnPostAdd(Veterinario veterinario)
        {
            repoVeterinario.AgregarVeterinario(veterinario);
            this.listaVeterinarios = repoVeterinario.GetVeterinarios();
        }

        public void OnPostDel(int id)
        {
            repoVeterinario.EliminarVeterinario(id);
            this.listaVeterinarios = repoVeterinario.GetVeterinarios();
        }


    }

    // public class Veterinario
    // {
    //     public int Index { get; set; }
    //     public String Nombres { get; set; }
    //     public String Apellidos { get; set; }
    //     public String Telefono { get; set; }
    //     public String Correo { get; set; }
    // }
}
