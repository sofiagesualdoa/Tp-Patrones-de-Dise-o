using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEj1
{
    internal abstract class PizzaBuilder
    {
        public abstract void ConstruirMasa();
        public abstract void ConstruirSalsa();
        public abstract void ConstruirQueso();
        public abstract void ConstruirIngredientes();

        public abstract Pizza GetPizza();
    }
}
