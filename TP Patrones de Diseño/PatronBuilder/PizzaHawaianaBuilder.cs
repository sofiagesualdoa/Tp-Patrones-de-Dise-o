using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEj1
{
    internal class PizzaHawaianaBuilder : PizzaBuilder
    {
        private Pizza pizza;
        public PizzaHawaianaBuilder()
        {
            pizza = new Pizza();
        }
        public override void ConstruirMasa()
        {
            pizza.Masa = "Masa tradicional";
        }
        public override void ConstruirSalsa()
        {
            pizza.Salsa = "Salsa de tomate";
        }
        public override void ConstruirQueso()
        {
            pizza.Queso = "Mozzarella";
        }
        public override void ConstruirIngredientes()
        {
            pizza.Ingredientes = "Jamón y ananá";
        }
        public override Pizza GetPizza()
        {
            return pizza;
        }
    }
}
