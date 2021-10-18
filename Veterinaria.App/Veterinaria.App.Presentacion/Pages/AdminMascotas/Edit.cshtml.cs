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
    public class EditModel : PageModel
    {
        private static IRepositorioMascota repoMascota = new RepositorioMascota(new Persistencia.AppContext());
       
        public IEnumerable<Mascota> listaMascotas { get; set;}
        [BindProperty]
        public modeloMascota mMascota { get; set; }
        [TempData]
        public string mensaje { get; set; } 

        public int idCuidador { get; set; }
        public int idMascota { get; set; }
        
        public Mascota mascota { get; set; }
        
        
        public void OnGet(int idMascota, int idCuidador)
        {
            this.idMascota = idMascota;
            this.idCuidador = idCuidador;
            mascota = repoMascota.ObtenerMascota(idMascota);
            mMascota = covertirModelo(mascota);
        }

        public ActionResult OnPostEdit(int idCuidador){
            
            if(ModelState.IsValid){
                
                var mascotaActualizada = mMascota.convertirModelo(this.mMascota);
                var mascotaModificada = repoMascota.EditarMascota(mascotaActualizada);
                
                mensaje = "Mascota actualizada exitosamente";
                return RedirectToPage("/AdminMascotas/AdminMascotas", new {idCuidador});
            }else{
                Console.WriteLine("Entro al else del editar");
                return Page();
            }
        }

        public modeloMascota covertirModelo(Mascota mascota){
            this.mMascota = new modeloMascota{
            Id = mascota.Id,
            Nombre = mascota.Nombre,
            Edad = mascota.Edad,
            Peso = mascota.Peso,
            Especie = mascota.Especie,
            Raza = mascota.Raza,
            Sexo = mascota.Sexo};
            
            return mMascota;
            }

            
    }
}
