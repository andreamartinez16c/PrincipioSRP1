using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSRP1
{
    // La clase CocheDB tiene una única responsabilidad: manejar las operaciones de la base de datos para los coches
    public class CocheDB
    {
        public void GuardarCocheDB(Coche coche)
        {
            // Lógica para guardar el coche en la base de datos
            Console.WriteLine($"Guardando el coche con marca: {coche.GetMarcaCoche()} en la base de datos.");
        }

        public void EliminarCocheDB(Coche coche)
        {
            // Lógica para eliminar el coche de la base de datos
            Console.WriteLine($"Eliminando el coche con marca: {coche.GetMarcaCoche()} de la base de datos.");
        }
    }
}
