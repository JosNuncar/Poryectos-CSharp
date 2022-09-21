using System;

namespace CiclosAsteriscos
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadLineas, totalAsteriscos, totalEspacios;

            Console.WriteLine("Programa para generar patrones con asteriscos");

            Console.WriteLine("\nFigura No. 1 - Ascendente a la izquierda:");
            for (cantidadLineas = 1; cantidadLineas <= 10; cantidadLineas++)
            {
                for (totalAsteriscos = 1; totalAsteriscos <= cantidadLineas; totalAsteriscos++)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.WriteLine("\nFigura No. 2 - Descendente a la izquierda:");
            for (cantidadLineas = 10; cantidadLineas >= 1; cantidadLineas--)
            {
                for (totalAsteriscos = 1; totalAsteriscos <= cantidadLineas; totalAsteriscos++)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.WriteLine("\nFigura No. 3 - Descendente a la derecha:");
            for (cantidadLineas = 10; cantidadLineas >= 1; cantidadLineas--)
            {
                totalEspacios = 10 - cantidadLineas;
                for (int i = 1; i <= totalEspacios; i++)
                    Console.Write(" ");

                for (totalAsteriscos = cantidadLineas; totalAsteriscos >= 1; totalAsteriscos--)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.WriteLine("\nFigura No. 4 - ascendente a la derecha:");
            for (cantidadLineas = 1; cantidadLineas <= 10; cantidadLineas++)
            {
                totalEspacios = 10 - cantidadLineas;
                for (int i = 1; i <= totalEspacios; i++)
                    Console.Write(" ");

                for (totalAsteriscos = cantidadLineas; totalAsteriscos >= 1; totalAsteriscos--)
                    Console.Write("*");

                Console.WriteLine();
            }

        }
    }
}
