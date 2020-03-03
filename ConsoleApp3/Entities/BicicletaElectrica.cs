using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entities
{
    public class BicicletaElectrica : Bicicleta
    {
        public override string TipoMotor { get => "tiene"; }

        public override int CantRuedas { get => 2; }
    }
}
