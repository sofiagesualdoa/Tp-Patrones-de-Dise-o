using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEj2
{
    internal class Director
    {
        private VehiculoBuilder builder;

        public Director(VehiculoBuilder builder)
        {
            this.builder = builder;
        }

        public Vehiculo ConstruirVehiculo(
            string motor,
            string transmision,
            string color)
        {
            builder.ConstruirModelo();
            builder.ConstruirMotor(motor);
            builder.ConstruirTransmision(transmision);
            builder.ConstruirColor(color);

            return builder.GetVehiculo();
        }
    }
}
