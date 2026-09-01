// See https://aka.ms/new-console-template for more information

using PatronBuilderEj2;

int tipoVehiculo = -1;

do
{
    Console.WriteLine("\n===== ELEGÍ TU VEHÍCULO =====");
    Console.WriteLine("1. Auto");
    Console.WriteLine("2. Camioneta");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");

    string entradaPrincipal = Console.ReadLine();

    if (!int.TryParse(entradaPrincipal, out tipoVehiculo))
    {
        Console.WriteLine("Opción inválida. Intente nuevamente.");
        tipoVehiculo = -1;
        continue;
    }

    switch (tipoVehiculo)
    {
        case 1:
            {
                int opcionMotorAuto;
                string motorAuto = "";

                do
                {
                    Console.WriteLine("\n===== MOTOR DE AUTO =====");
                    Console.WriteLine("1. Nafta 1.6");
                    Console.WriteLine("2. Híbrido");
                    Console.WriteLine("3. Eléctrico");
                    Console.Write("Seleccione una opción: ");

                    if (!int.TryParse(Console.ReadLine(), out opcionMotorAuto))
                    {
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        continue;
                    }

                    switch (opcionMotorAuto)
                    {
                        case 1:
                            motorAuto = "Nafta 1.6";
                            break;
                        case 2:
                            motorAuto = "Híbrido";
                            break;
                        case 3:
                            motorAuto = "Eléctrico";
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }

                } while (opcionMotorAuto < 1 || opcionMotorAuto > 3);


                int opcionTransmisionAuto;
                string transmisionAuto = "";

                do
                {
                    Console.WriteLine("\n===== TRANSMISIÓN DE AUTO =====");
                    Console.WriteLine("1. Manual");
                    Console.WriteLine("2. Automática");
                    Console.Write("Seleccione una opción: ");

                    if (!int.TryParse(Console.ReadLine(), out opcionTransmisionAuto))
                    {
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        continue;
                    }

                    switch (opcionTransmisionAuto)
                    {
                        case 1:
                            transmisionAuto = "Manual";
                            break;
                        case 2:
                            transmisionAuto = "Automática";
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }

                } while (opcionTransmisionAuto < 1 || opcionTransmisionAuto > 2);


                int opcionColorAuto;
                string colorAuto = "";

                do
                {
                    Console.WriteLine("\n===== COLOR DE AUTO =====");
                    Console.WriteLine("1. Negro Ónix");
                    Console.WriteLine("2. Blanco Glaciar");
                    Console.WriteLine("3. Rojo Ferrari");
                    Console.Write("Seleccione una opción: ");

                    if (!int.TryParse(Console.ReadLine(), out opcionColorAuto))
                    {
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        continue;
                    }

                    switch (opcionColorAuto)
                    {
                        case 1:
                            colorAuto = "Negro Ónix";
                            break;
                        case 2:
                            colorAuto = "Blanco Glaciar";
                            break;
                        case 3:
                            colorAuto = "Rojo Ferrari";
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }

                } while (opcionColorAuto < 1 || opcionColorAuto > 3);


                VehiculoBuilder builderAuto = new AutoBuilder();
                Director directorAuto = new Director(builderAuto);

                Vehiculo auto = directorAuto.ConstruirVehiculo(motorAuto, transmisionAuto, colorAuto);
                auto.Mostrar();
                break;
            }

        case 2:
            {
                int opcionMotorCamioneta;
                string motorCamioneta = "";

                do
                {
                    Console.WriteLine("\n===== MOTOR DE CAMIONETA =====");
                    Console.WriteLine("1. Turbodiesel 2.8");
                    Console.WriteLine("2. Nafta V6");
                    Console.WriteLine("3. Bi-Turbo Híbrido");
                    Console.Write("Seleccione una opción: ");

                    if (!int.TryParse(Console.ReadLine(), out opcionMotorCamioneta))
                    {
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        continue;
                    }

                    switch (opcionMotorCamioneta)
                    {
                        case 1:
                            motorCamioneta = "Turbodiesel 2.8";
                            break;
                        case 2:
                            motorCamioneta = "Nafta V6";
                            break;
                        case 3:
                            motorCamioneta = "Bi-Turbo Híbrido";
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }

                } while (opcionMotorCamioneta < 1 || opcionMotorCamioneta > 3);


                int opcionTransmisionCamioneta;
                string transmisionCamioneta = "";

                do
                {
                    Console.WriteLine("\n===== TRANSMISIÓN DE CAMIONETA =====");
                    Console.WriteLine("1. Manual de 6 marchas");
                    Console.WriteLine("2. Automática Secuencial");
                    Console.Write("Seleccione una opción: ");

                    if (!int.TryParse(Console.ReadLine(), out opcionTransmisionCamioneta))
                    {
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        continue;
                    }

                    switch (opcionTransmisionCamioneta)
                    {
                        case 1:
                            transmisionCamioneta = "Manual de 6 marchas";
                            break;
                        case 2:
                            transmisionCamioneta = "Automática Secuencial";
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }

                } while (opcionTransmisionCamioneta < 1 || opcionTransmisionCamioneta > 2);


                int opcionColorCamioneta;
                string colorCamioneta = "";

                do
                {
                    Console.WriteLine("\n===== COLOR DE CAMIONETA =====");
                    Console.WriteLine("1. Gris Plata");
                    Console.WriteLine("2. Azul Oscuro");
                    Console.WriteLine("3. Blanco Perla");
                    Console.Write("Seleccione una opción: ");

                    if (!int.TryParse(Console.ReadLine(), out opcionColorCamioneta))
                    {
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        continue;
                    }

                    switch (opcionColorCamioneta)
                    {
                        case 1:
                            colorCamioneta = "Gris Plata";
                            break;
                        case 2:
                            colorCamioneta = "Azul Oscuro";
                            break;
                        case 3:
                            colorCamioneta = "Blanco Perla";
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }

                } while (opcionColorCamioneta < 1 || opcionColorCamioneta > 3);


                VehiculoBuilder builderCamioneta = new CamionetaBuilder();
                Director directorCamioneta = new Director(builderCamioneta);

                Vehiculo camioneta = directorCamioneta.ConstruirVehiculo(motorCamioneta, transmisionCamioneta, colorCamioneta);
                camioneta.Mostrar();
                break;
            }

        case 0:
            Console.WriteLine("\nPrograma finalizado.");
            break;
    }

} while (tipoVehiculo != 0);
