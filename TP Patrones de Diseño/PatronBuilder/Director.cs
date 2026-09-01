using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEj1
{
    internal class Director
    {
        private PizzaBuilder builder;

        public Director(PizzaBuilder builder)
        {
            this.builder = builder;
        }

        public Pizza Construir()
        {
            builder.ConstruirMasa();
            builder.ConstruirSalsa();
            builder.ConstruirQueso();
            builder.ConstruirIngredientes();

            return builder.GetPizza();
        }
    }
}
