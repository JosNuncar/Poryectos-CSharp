
using System;
using System.Globalization;

namespace CalculadoraNotasTrimestre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular la media de los trimestres");
            Console.WriteLine("Si el promedio es mayor o igual a 5 se considera que aprobó el curso.");
            Console.WriteLine("El valor de cada nota debe estar entre 0 y 10.");

            
            //CultureInfo miCultura = CultureInfo.CurrentCulture;

            //Console.WriteLine($"\nLa configuración regional actual es {miCultura.Name}");
            //Console.WriteLine($"El separador de decimales es \"{miCultura.NumberFormat.NumberDecimalSeparator}\"\n\n");

            
            const int cantidadNotas = 3;

            //Variables a utilizar:            
            int notaActual = 1; // Contador de notas
            float nota = 0, promedio = 0;  // Variables para leer la nota y almacenar el promedio
            bool datoCorrecto; // Variable booleana para saber si el dato ingresado es correcto

            while (notaActual <= cantidadNotas)
            {
                datoCorrecto = false; // Para cada numero, se asume que fue ingresado erróneament.
                while (datoCorrecto == false)
                {
                    try
                    {
                        Console.Write($"Ingresa el valor de la nota No. {notaActual}: ");
                        nota = float.Parse(Console.ReadLine());
                        if (nota >= 0 && nota <= 10.00)
                        {
                            datoCorrecto = true;
                        }
                        else
                        {
                            Console.WriteLine("La nota debe ser un valor numérico entre 0 y 10. Intentalo de nuevo.\n\n");
                        }
                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("El dato ingresado debe ser numérico. Intenta nuevamente.");
                        Console.WriteLine($"{elError.Message}\n\n");
                    }
                }

                notaActual++;
                promedio += nota;
            }

            // Terminado el ingreso de datos, se calcula el promedio
            promedio /= cantidadNotas; //Utilizamos la asignación compuesta: Dividimos lo que había en promedio con la cantidad de notas

            //Visualizamos los resultados
            Console.Write($"\n\nEl promedio del curso es {promedio}. ");

            //Evaluamos si aprobó o no el semestre
            if (promedio >= 5)
            {
                Console.WriteLine("El estudiante ha aprobado el curso");
            }
            else
            {
                Console.WriteLine("El estudiante ha suspendido el curso");
            }
        }
    }
}