using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Moto : Vehiculo, IMaquina
    {
        public override string TipoMotor { get => "110cc"; }
        public override int CantRuedas { get => 2; }

        public string Arrancar()
        {
            return "La moto siempre arranca con bujias Hescher";
        }
    }
}
