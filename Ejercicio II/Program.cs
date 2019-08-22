using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";
            string valorIngresado;
            bool flag = false;
            double cubo, cuadrado;
            int numeroIngresado;
            do
            {
                Console.Write("Ingrese un numero para calcular su cuadrado y su cubo: ");
                valorIngresado = Console.ReadLine();
                if (int.TryParse(valorIngresado, out numeroIngresado) && numeroIngresado > 0)
                {
                    cuadrado = Math.Pow(numeroIngresado, 2);
                    cubo = Math.Pow(numeroIngresado, 3);
                    Console.WriteLine("El cuadrado de {0} es {1} y su cubo es {2}", numeroIngresado, cuadrado, cubo);
                    flag = true;
                }
                else
                {
                    Console.WriteLine("ERROR! Reingrese Numero!");
                }
            } while (!flag);
            Console.ReadKey();
        }
    }
}
