using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";
            int i, j,z;
            int acumuladorAnterior = 0;
            int acumuladorPosterior = 0;
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                for (i = 1; i < numero; i++)
                {
                    acumuladorAnterior = 0;
                    acumuladorPosterior = 0;
                    for (j = 1; j<i-1;j++)
                    {
                        acumuladorAnterior += j;
                    }
                    for (z = i + 1; acumuladorAnterior < acumuladorPosterior; z++)
                    {
                        acumuladorPosterior += z;
                    }
                    if(acumuladorPosterior == acumuladorAnterior)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Fin del programa");
            }
            Console.ReadKey();
        }
    }
}
