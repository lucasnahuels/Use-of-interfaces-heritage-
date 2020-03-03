using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Bicicleta : Vehiculo
    {
        public override string TipoMotor { get => "no tiene";}

        public override int CantRuedas { get => 2; }
    }
}
