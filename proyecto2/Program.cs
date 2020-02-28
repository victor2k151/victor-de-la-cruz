using System;

namespace proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre completo");
            String nombre = Console.ReadLine();

            Console.WriteLine("Edad");
            String edad = Console.ReadLine();

            Console.WriteLine("Su nombre es " + nombre + " y tiene " + edad + " años");

            Console.ReadLine();

        }
    }
}
