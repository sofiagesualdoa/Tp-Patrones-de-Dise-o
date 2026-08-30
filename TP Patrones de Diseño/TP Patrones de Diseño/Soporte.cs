using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Patrones_de_Diseño
{
    public abstract class Soporte
    {
        protected Soporte siguiente;

        public void SetSiguiente(Soporte siguiente)
        {
            this.siguiente = siguiente;
        }

        public abstract void Atender(int complejidad);
    }
}
