using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_XX
{
    class Program
    {
        static void Main(string[] args)
        {

            Peso aux = new Peso(100);
            Dolar auxD = new Dolar(1);
            Euro auxE = new Euro(1);
            Peso res = aux + auxE;
            Console.WriteLine(res.GetCantidad());
            Console.ReadKey();
        }
    }
}
    