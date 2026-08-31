using Ejemplo_2___Chain;

Vendedor vendedor = new Vendedor();
Supervisor supervisor = new Supervisor();
Gerente gerente = new Gerente();
vendedor.SetSiguiente(supervisor);
supervisor.SetSiguiente(gerente);
int opcion;
double descuento;

do
{
    Console.WriteLine("   SISTEMA DE DESCUENTOS");
    Console.WriteLine("1. Solicitar descuento");
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
            Console.Write("Ingrese el porcentaje de descuento solicitado: ");
            if (!double.TryParse(Console.ReadLine(), out descuento))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                Console.WriteLine();
                continue;
            }
            if (descuento < 0)
            {
                Console.WriteLine("El descuento no puede ser negativo.");
                Console.WriteLine();
                continue;
            }
            Console.WriteLine("Procesando solicitud...");
            vendedor.Aprobar(descuento);
            break;
        case 2:
            Console.WriteLine("Saliendo del sistema...");
            break;
        default:
            Console.WriteLine("Opción inválida. Ingrese 1 o 2.");
            break;
    }
} 
while (opcion != 2);