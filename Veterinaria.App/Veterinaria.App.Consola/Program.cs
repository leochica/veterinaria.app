using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
  class Program
  {

    private static IRepositorioVeterinario repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
    private static IRepositorioCuidador repoCuidador = new RepositorioCuidador(new Persistencia.AppContext());
    private static IRepositorioMascota repoMascota = new RepositorioMascota(new Persistencia.AppContext());

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World! \n");
      AgregarVeterinario();
      //EditarVeterinario(1);
      //BuscarVeterinario(3);
      //EliminarVeterinario(3);
      //===============================
      //AgregarCuidador();
      //EditarCuidador(1);
      //BuscarCuidador(1);
      //EliminarCuidador(1);
      //===============================
      //AgregarMascota();
      //EditarMascota(1);
      //BuscarMascota(1);
      //EliminarMascota(1);

    }


    /*
    =========================
    CRUD VETERINARIO
    =========================
    */

    private static void AgregarVeterinario()
    {
      Veterinario veterinario = new Veterinario
      {
        Nombres = "Camila",
        Apellidos = "Mejia",
        Edad = 30,
        Genero = Genero.Femenino,
        Telefono = "3007654321",
        Direccion = "Cl 2 N 1",
        Correo = "cami@gmail.com",
        Contrasenia = "asdfgh",
        FechaRegistro = new DateTime(2021, 09, 26),
        Especialidad = "Cirujano",
        TarjetaProfesional = "TP123"
      };
      repoVeterinario.AgregarVeterinario(veterinario);
    }

    private static void EditarVeterinario(int IdVeterinario)
    {
      Veterinario veterinario = new Veterinario
      {
        Id = IdVeterinario,
        Nombres = "Carlos",
        Apellidos = "Riascos",
        Edad = 20,
        Genero = Genero.Otro,
        Telefono = "204050",
        Direccion = "Cl 1 N 1",
        Correo = "carlos@mail.com",
        Contrasenia = "123456",
        FechaRegistro = new DateTime(2021, 09, 26),
        Especialidad = "General",
        TarjetaProfesional = "TP1234"
      };
      repoVeterinario.EditarVeterinario(veterinario);
    }

    private static void BuscarVeterinario(int IdVeterinario)
    {
      var veterinario = repoVeterinario.ObtenerVeterinario(IdVeterinario);
      var datoNombre = "El nombre del veterinario es: " + veterinario.Nombres + "\n";
      var datoApellido = "El apellido del veterinario es: " + veterinario.Apellidos + "\n";
      var datoEdad = "La edad del veterinario es: " + veterinario.Edad + "\n";
      Console.WriteLine(datoNombre);
    }

    private static void EliminarVeterinario(int IdVeterinario)
    {
      repoVeterinario.EliminarVeterinario(IdVeterinario);
    }



    /*
    =========================
    CRUD CUIDADOR
    =========================
    */

    private static void AgregarCuidador()
    {
      Cuidador cuidador = new Cuidador
      {
        Nombres = "Sophia",
        Apellidos = "Pretel",
        Edad = 18,
        Genero = Genero.Femenino,
        Telefono = "4050",
        Direccion = "Cl 1 N 2",
        Correo = "sophia@gmail.com",
        Contrasenia = "ytrewq",
        FechaRegistro = new DateTime(2021, 09, 27),
      };
      repoCuidador.AgregarCuidador(cuidador);
    }

    private static void EditarCuidador(int IdCuidador)
    {
      Cuidador cuidador = new Cuidador
      {
        Id = IdCuidador,
        Nombres = "Carlos",
        Apellidos = "Riascos",
        Edad = 20,
        Genero = Genero.Otro,
        Telefono = "204050",
        Direccion = "Cl 1 N 1",
        Correo = "carlos@mail.com",
        Contrasenia = "123456",
        FechaRegistro = new DateTime(2021, 09, 26),
      };
      repoCuidador.EditarCuidador(cuidador);
    }

    private static void BuscarCuidador(int IdCuidador)
    {
      var cuidador = repoCuidador.ObtenerCuidador(IdCuidador);
      var datoNombre = "El nombre del cuidador es: " + cuidador.Nombres + "\n";
      var datoApellido = "El apellido del cuidador es: " + cuidador.Apellidos + "\n";
      var datoDireccion = "La direccion del cuidador es: " + cuidador.Direccion + "\n";
      Console.WriteLine(datoNombre);
    }

    private static void EliminarCuidador(int IdCuidador)
    {
      repoCuidador.EliminarCuidador(IdCuidador);
    }



    /*
    =========================
    CRUD MASCOTA
    =========================
    */

    private static void AgregarMascota()
    {
      Mascota mascota = new Mascota
      {
        Nombre = "Rambo",
        Edad = 5,
        Peso = 30,
        Especie = "Perro",
        Raza = "Criollo",
        Sexo = SexoAnimal.Macho,
      };
      repoMascota.AgregarMascota(mascota);
    }

    private static void EditarMascota(int IdMascota)
    {
      Mascota mascota = new Mascota
      {
        Id = IdMascota,
        Nombre = "Rambo",
        Edad = 6,
        Peso = 32,
      };
      repoMascota.EditarMascota(mascota);
    }

    private static void BuscarMascota(int IdMascota)
    {
      var mascota = repoMascota.ObtenerMascota(IdMascota);
      var datoNombre = "El nombre de la mascota es: " + mascota.Nombre + "\n";
      var datoEdad = "La edad de la mascota es: " + mascota.Edad + "\n";
      var datoPeso = "El peso de la mascota es: " + mascota.Peso + "\n";
      Console.WriteLine(datoNombre);
    }

    private static void EliminarMascota(int IdMascota)
    {
      repoMascota.EliminarMascota(IdMascota);
    }






  }
}
