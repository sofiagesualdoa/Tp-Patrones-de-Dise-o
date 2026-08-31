using Microsoft.VisualBasic;
using TP_Patrones_de_Diseño;

SoporteNivel1 nivel1 = new SoporteNivel1();
SoporteNivel2 nivel2 = new SoporteNivel2();
SoporteNivel3 nivel3 = new SoporteNivel3();
nivel1.SetSiguiente(nivel2);
nivel2.SetSiguiente(nivel3);
int opcion, complejidad;
do
{
    Console.WriteLine("SISTEMA DE SOPORTE");
    Console.WriteLine("1. Registrar problema");
    Console.WriteLine("2. Salir");
    Console.Write("Seleccione una opción: ");
    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
        continue;
    }
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Seleccione la complejidad:");
            Console.WriteLine("1. Simple");
            Console.WriteLine("2. Intermedio");
            Console.WriteLine("3. Complejo");
            Console.Write("Ingrese la complejidad: ");
            if (!int.TryParse(Console.ReadLine(), out complejidad))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                Console.WriteLine();
                continue;
            }
            Console.WriteLine("Procesando solicitud...");
            nivel1.Atender(complejidad);
            break;
        case 2:
            Console.WriteLine("Saliendo del sistema...");
            break;
        default:
            Console.WriteLine("Opción inválida. Ingrese 1 o 2.");
            break;
    }
} while (opcion != 2);
