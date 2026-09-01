using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEj1
{
    internal class Pizza
    {
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public string Queso { get; set; }
        public string Ingredientes { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("\n--- PIZZA ---");
            Console.WriteLine($"Masa: {Masa}");
            Console.WriteLine($"Salsa: {Salsa}");
            Console.WriteLine($"Queso: {Queso}");
            Console.WriteLine($"Ingredientes: {Ingredientes}");
        }
    }
}
