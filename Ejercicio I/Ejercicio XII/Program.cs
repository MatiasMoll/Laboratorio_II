using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_XII
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            char opcion = 'n';
            int numero;
            int acumulador = 0;
            do {
                Console.Write("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    acumulador += numero;
                    Console.Write("Continuar(S/N)?: ");
                    do { 
                        if(!char.TryParse(Console.ReadLine(), out opcion))
                        {
                            Console.Write("Opcion Incorrecta, Reintente: ");
                        }else
                        {
                            flag = true;
                        }
                   } while (!flag);

                }
            } while (ValidarRespuesta.ValidarS_N(opcion));
            Console.WriteLine("La suma es: {0}", acumulador);
            Console.ReadKey();
        }
    }
}
