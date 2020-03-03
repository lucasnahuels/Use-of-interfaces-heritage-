using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Auto : Vehiculo, IMaquina
    {
        public override string TipoMotor { get => "1.4"; }
        public override int CantRuedas { get => 4; }
        public string Arrancar()
        {
            return "el automovil siempre arranca con bujias Hescher";
        }
    }
}
