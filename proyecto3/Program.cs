using System;

namespace proyecto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un dia de la semana");
            String dia = Console.ReadLine();

            switch (dia.ToLower())
            {

                case "Lunes":
                case "Martes":
                case "Miercoles":
                case "Jueves":
                case "Viernes":
                    Console.WriteLine("El dia que ingreso no es fin de semana");
                    break;
                case "Sabado":
                case "Domingo":
                    Console.WriteLine("El dia que ingreso si es fin de semana");
                    break;

                default:
                    Console.WriteLine("ERROR, ingrese un dia de la semana.");
                    break;
            }
    }
         }

}

