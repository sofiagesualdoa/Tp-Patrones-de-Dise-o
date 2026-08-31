using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2___Chain
{
    public class Gerente : Aprobador
    {
        public override void Aprobar(double descuento)
        {
            if (descuento <= 50)
            {
                Console.WriteLine("El descuento fue aprobado por el Gerente.");
            }
            else
            {
                Console.WriteLine("El Gerente no puede aprobar este descuento.");
                if (siguiente != null)
                {
                    siguiente.Aprobar(descuento);
                }
                else
                {
                    Console.WriteLine("Ningún responsable puede aprobar el descuento solicitado.");
                }
            }
        }
    }
}
