using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilderEj2
{
    internal class AutoBuilder : VehiculoBuilder
    {
        private Vehiculo vehiculo;
        public AutoBuilder()
        {
            vehiculo = new Vehiculo();
        }
        public override void ConstruirModelo()
        {
            vehiculo.Modelo = "Auto";
        }
        public override void ConstruirMotor(string motor)
        {
            vehiculo.Motor = motor;
        }
        public override void ConstruirTransmision(string transmision)
        {
            vehiculo.Transmision = transmision;
        }
        public override void ConstruirColor(string color)
        {
            vehiculo.Color = color;
        }
        public override Vehiculo GetVehiculo()
        {
            return vehiculo;
        }
    }
}
