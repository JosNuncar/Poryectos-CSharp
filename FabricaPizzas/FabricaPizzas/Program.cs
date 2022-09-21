using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPizzas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa de gestion de pizzas de una fábrica");
            Console.WriteLine("Se producirán 500 pizzas");

            Pizza[] lasPizzas = new Pizza[500];

            string[] tiposMasa = { "Fina", "Americana", "Queso" };
            InicializaLotePizzas(lasPizzas, tiposMasa);

            VisualizaLotePizzas(lasPizzas);

            int[] totalesMasa = TotalesPorMasa(lasPizzas, tiposMasa);

            Console.WriteLine("\n\nLos totales por masa son:");
            for (int k = 0; k < tiposMasa.Length; k++)
            {
                Console.WriteLine($"Masa: {tiposMasa[k]}, total: {totalesMasa[k]}");
            }
        }

        public static void InicializaLotePizzas(Pizza[] mPizzas, string[] nMasas)
        {
            Random aleatorio = new Random();

            int tipoDePizza; // 0: Congelada, 1: Asada, 2: Procesada
            int numeroHorno; // Toma valores entre 1 y 7
            int diasCaducidad; // Toma Valores entre 1 y 30 días            

            for (int i = 0; i < mPizzas.Length; i++)
            {
                tipoDePizza = aleatorio.Next(3);
                numeroHorno = aleatorio.Next(1, 8);
                diasCaducidad = aleatorio.Next(1, 31);

                switch (tipoDePizza)
                {
                    case 0:
                        mPizzas[i] = new PizzaCongelada(
                            nMasas[aleatorio.Next(nMasas.Length)],
                            diasCaducidad,
                            numeroHorno,
                            aleatorio.Next(30, 91), //Dias de Congelado
                            "Congelada");
                        break;

                    case 1:
                        mPizzas[i] = new PizzaPiedra(
                            nMasas[aleatorio.Next(nMasas.Length)],
                            diasCaducidad,
                            numeroHorno,
                            aleatorio.Next(20, 101), // Temperatura de Coccion
                            "Horno");
                        break;

                    case 2:
                        mPizzas[i] = new PizzaLowCost(
                           nMasas[aleatorio.Next(nMasas.Length)],
                            diasCaducidad,
                            numeroHorno,
                            aleatorio.Next(20, 101), // Temperatura de Coccion
                            aleatorio.Next(30, 91), //Dias de Congelado
                            "LowCost");
                        break;
                }
            }
        }

        public static int[] TotalesPorMasa(Pizza[] mPizzas, string[] nMasas)
        {
            int[] resultado = new int[nMasas.Length];

            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

         
            for (int i = 0; i < mPizzas.Length; i++)
                for (int j = 0; j < nMasas.Length; j++)
                    if (mPizzas[i].TipoDeMasa == nMasas[j])
                        resultado[j]++;

            return resultado;
        }

        public static void VisualizaLotePizzas(Pizza[] mPizzas)
        {
   

            for (int i = 0; i < mPizzas.Length; i++)
            {
                Console.WriteLine($"Pizza Nº {(i + 1)} " +
                    $"- Del tipo {mPizzas[i].TipoPizza} " +
                    $"- De masa {mPizzas[i].TipoDeMasa}");
            }

        }
    }
}