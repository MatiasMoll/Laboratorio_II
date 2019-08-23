using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            int cantNumeros = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int acumulador = 0;
            int numeroIngresado;
            int numeroAMostrar;
            do {
                Console.Write("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    if (Validaciones.Validar(numeroIngresado, -100, 100))
                    {
                        if (numeroIngresado < min)
                        {
                            min = numeroIngresado;
                        }
                        if (numeroIngresado > max)
                        {
                            max = numeroIngresado;
                        }
                        acumulador += numeroIngresado;
                        cantNumeros++;
                    }
                    else
                    {
                        Console.WriteLine("ERROR! Reintente.");
                    }
                }
            } while (cantNumeros < 10);
            numeroAMostrar = acumulador / cantNumeros;
            Console.Write("El minimo es: {0}, El maximo es: {1}, y el promedio es: {2}", min, max, numeroAMostrar);
            Console.ReadKey();
        }
    }
}
