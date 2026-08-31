using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2___Chain
{
    public abstract class Aprobador
    {
        protected Aprobador siguiente;

        public void SetSiguiente(Aprobador siguiente)
        {
            this.siguiente = siguiente;
        }

        public abstract void Aprobar(double descuento);
    }
}
