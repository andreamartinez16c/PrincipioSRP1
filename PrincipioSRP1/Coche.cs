using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSRP1
{
    // La clase Coche tiene una única responsabilidad: representar un coche
    public class Coche
    {
        public string Marca { get; private set; }

        public Coche(string marca)
        {
            Marca = marca;
        }

        public string GetMarcaCoche()
        {
            return Marca;
        }
    }
}
