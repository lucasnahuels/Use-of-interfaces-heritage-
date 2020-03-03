using ConsoleApp3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Elija el nro del vehiculo que desea imprimir:");
            Console.WriteLine("1- Automovil");
            Console.WriteLine("2- Motocicleta");
            Console.WriteLine("3- Bicicleta");
            Console.WriteLine("4- Bicicleta electrica");
            Console.WriteLine("5- Tv");
            string vehiculoElegido = Console.ReadLine();

            if (Int32.Parse(vehiculoElegido) == 1)
            {
                Vehiculo vehiculo = new Auto();
                Console.WriteLine(vehiculo.ImprimirCantRuedasYTipoMotor());
            }
            if (Int32.Parse(vehiculoElegido) == 2)
            {
                Vehiculo vehiculo = new Moto();
                Imprimir(vehiculo);
            }
            if (Int32.Parse(vehiculoElegido)== 3)
            {
                Vehiculo vehiculo = new Bicicleta();
                Console.WriteLine(vehiculo.ImprimirCantRuedasYTipoMotor());
            }
            if (Int32.Parse(vehiculoElegido) == 4)
            {
                Vehiculo vehiculo = new BicicletaElectrica();
                Console.WriteLine(vehiculo.ImprimirCantRuedasYTipoMotor());
            }
            if (Int32.Parse(vehiculoElegido) == 5)
            {
                Tv tv = new Tv();
                Console.WriteLine(tv.Arrancar());

                ImprimirArrancar<Tv>(tv);
                ImprimirArrancar2(tv);
            }



        }

        static public void Imprimir(Vehiculo vehiculo) //debe ser static para evitar instanciar Program
        {
            Console.WriteLine( vehiculo.ImprimirCantRuedasYTipoMotor());
        }

        static public void ImprimirArrancar<T>(T item) where T: IMaquina
        {
            Console.WriteLine(item.Arrancar());
        }

        static public void ImprimirArrancar2(IMaquina item)
        {
            Console.WriteLine(item.Arrancar());
        }

        static public T ImprimirArrancar3<T>(T item) where T: IMaquina, IVehiculo
        {
            return item;
        }

        static public IMaquina ImprimirArrancar4(IMaquina item)
        {
            return item;
        }


    }
}
