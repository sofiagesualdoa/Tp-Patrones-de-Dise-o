using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEj2
{
    internal class Vehiculo
    {
        public string Modelo { get; set; }
        public string Motor { get; set; }
        public string Transmision { get; set; }
        public string Color { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("\n--- VEHÍCULO CONFIGURADO ---");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Motor: {Motor}");
            Console.WriteLine($"Transmisión: {Transmision}");
            Console.WriteLine($"Color: {Color}");
        }
    }
}
