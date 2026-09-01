using PatronBuilderEj1;
int tipoPizza = -1;
do
{
    Console.WriteLine("\n===== ELEGÍ TU PIZZA =====");
    Console.WriteLine("1. Pizza Hawaiana");
    Console.WriteLine("2. Pizza Vegetariana");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");

    string entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out tipoPizza))
    {
        Console.WriteLine("Opción inválida. Intente nuevamente.");
        tipoPizza = -1;
        continue;
    }
    switch (tipoPizza)
    {
        case 1:
            PizzaBuilder builderHawaiana = new PizzaHawaianaBuilder();
            Director directorHawaiana = new Director(builderHawaiana);
            Pizza pizzaHawaiana = directorHawaiana.Construir();
            pizzaHawaiana.Mostrar();
            break;

        case 2:
            PizzaBuilder builderVegetariana = new PizzaVegetarianaBuilder();
            Director directorVegetariana = new Director(builderVegetariana);
            Pizza pizzaVegetariana = directorVegetariana.Construir();
            pizzaVegetariana.Mostrar();
            break;

        case 0:
            Console.WriteLine("\nPrograma finalizado.");
            break;
    }

} while (tipoPizza != 0);

