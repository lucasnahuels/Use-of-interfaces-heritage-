using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public abstract class Vehiculo : IVehiculo//implementar imprimir ruedas y tipo motor
    {
        public virtual int CantRuedas { get; set; } //propiedad
        //public virtual int CantRuedas atributo
        public virtual string TipoMotor{ get; set; }

        public string ImprimirCantRuedasYTipoMotor()
        {
            return "El vehiculo tiene " + CantRuedas.ToString() + "ruedas y su tipo de motor es : " + TipoMotor;
        }
    }
}
