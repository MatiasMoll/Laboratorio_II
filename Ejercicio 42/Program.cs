using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MiClase aux = new MiClase("asd");
                aux.MetodoInsancia();
            }catch (MiExcepcion e)
            {
                Exception aux = e;
                do
                {
                    Console.WriteLine(aux.Message);
                    aux = aux.InnerException;

                } while (!(aux is null));
            }
            Console.ReadKey();
        }
    }
}
