using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Ingrese el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            n3 = int.Parse(Console.ReadLine());
            int suma = n1 + n2 + n3;

            Console.WriteLine("El resultado es " + suma);

            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
