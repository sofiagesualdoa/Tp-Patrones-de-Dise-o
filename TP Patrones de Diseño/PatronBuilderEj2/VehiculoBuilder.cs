using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEj2
{
    internal abstract class VehiculoBuilder
    {
        public abstract void ConstruirModelo();
        public abstract void ConstruirMotor(string motor);
        public abstract void ConstruirTransmision(string transmision);
        public abstract void ConstruirColor(string color);

        public abstract Vehiculo GetVehiculo();

    }
}
