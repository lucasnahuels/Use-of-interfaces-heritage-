using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Tv : IMaquina
    {
        public string Arrancar()
        {
            return "Encendió la tv";
        }
    }
}
