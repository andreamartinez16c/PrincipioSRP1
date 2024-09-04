using PrincipioSRP1;
using System;

namespace PrincipioSRP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Coche
            Coche miCoche = new Coche("Toyota");

            // Crear una instancia de CocheDB
            CocheDB cocheDB = new CocheDB();

            // Guardar el coche en la base de datos
            cocheDB.GuardarCocheDB(miCoche);

            // Eliminar el coche de la base de datos
            cocheDB.EliminarCocheDB(miCoche);

            // Esperar a que el usuario presione una tecla antes de cerrar la aplicación
            Console.ReadKey();
        }
    }
}
