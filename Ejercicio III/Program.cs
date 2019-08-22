using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";
            bool flag = false;
            string valorIngresado;
            int numero;
            do { 
                Console.Write("Ingrese un numero para mostrar los primos: ");
                valorIngresado = Console.ReadLine();
                if(int.TryParse(valorIngresado, out numero))
                {
                    if (numero <= 1)
                    {
                        Console.WriteLine("ERROR! El numero ingresado debe ser MAYOR a 1.");
                    }
                    else
                    {
                        int j;
                        int i;
                        for (i = 2; i <= numero;i++)
                        {
                            for(j = 2; j < i; j++)
                            {
                                if((i%j) == 0)
                                {
                                    break;
                                }
                            }
                            if (i == j)
                            {
                                Console.WriteLine("{0} es primo.", i);
                            }
                        }
                    }
                    flag = true;
                }else
                {
                    Console.WriteLine("ERROR! Ingrese un valor valido.");
                }
            }while (!flag);
            Console.ReadKey();
        }
    }
}
