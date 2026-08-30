using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Patrones_de_Diseño
{
    public class SoporteNivel1 : Soporte
    {
        public override void Atender(int complejidad)
        {
            if (complejidad == 1)
                Console.WriteLine("Problema resuelto por Soporte Nivel 1");
            else
            {
                Console.WriteLine("Soporte Nivel 1 no puede resolver el problema.");

                if (siguiente != null)
                {
                    siguiente.Atender(complejidad);
                }
                else
                {
                    Console.WriteLine("Ningún nivel de soporte pudo resolver el problema.");
                }
            }
        }
    }
}
