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
            string valorIngresado;
            int numero;
            Console.Write("Ingrese un numero para mostrar los primos: ");
            valorIngresado = Console.ReadLine();
            if(int.TryParse(valorIngresado, out numero))
            {
                for(int i=0;i<numero;i++)
                {
                    
                }
            }
        }
    }
}
