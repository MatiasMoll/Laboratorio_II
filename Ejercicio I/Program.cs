using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string valorIngresado;
            int numero;
            int sumaNumeros = 0;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            Console.Title = "Ejercicio Nro 1";
            do {
                Console.WriteLine("Ingrese un numero: ");
                valorIngresado = Console.ReadLine();
                if(int.TryParse(valorIngresado,out numero))
                {
                    sumaNumeros += numero;
                    if(numero < minimo)
                    {
                        minimo = numero;
                    }
                    if(numero > maximo)
                    {
                        maximo = numero;
                    }
                    i++;
                }
                else
                {
                    Console.Write("Error! Reintente.");
                }
            } while (i < 5);
            float promedio = sumaNumeros / i;
            Console.WriteLine("El numero minimo es: {0:#,###.00}, el maximo es: {1:#,###.00}, el promedio es: {2:#,###.00}", minimo, maximo, promedio);
            Console.ReadKey();



        }
    }
}
