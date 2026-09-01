using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEj1
{
    internal class PizzaVegetarianaBuilder :PizzaBuilder
    {
        private Pizza pizza;
        public PizzaVegetarianaBuilder()
        {
            pizza = new Pizza();
        }
        public override void ConstruirMasa()
        {
            pizza.Masa = "Masa integral";
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
            pizza.Ingredientes = "Tomate, morrón, cebolla y aceitunas";
        }
        public override Pizza GetPizza()
        {
            return pizza;
        }
    }
}
