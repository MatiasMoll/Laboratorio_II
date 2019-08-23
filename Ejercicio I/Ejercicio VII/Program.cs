using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 7";
            int acumulador = 0;
            int diaAct,mesAct,añoAct,diaIng,mesIng,añoIng;
            string dia, mes, año;
            DateTime fecha = DateTime.Now;
            int.TryParse(fecha.ToString("dd"), out diaAct);
            int.TryParse(fecha.ToString("MM"), out mesAct);
            int.TryParse(fecha.ToString("yyyy"),out añoAct);
            Console.Write("Ingrese el dia de tu nacimiento: ");
            dia = Console.ReadLine();
            Console.Write("Ingrese el mes de tu nacimiento: ");
            mes = Console.ReadLine();
            Console.Write("Ingrese el año de tu nacimiento: ");
            año = Console.ReadLine();
            if (int.TryParse(dia, out diaIng) && int.TryParse(mes, out mesIng) && int.TryParse(año, out añoIng)&&
                diaIng < 32 && diaIng>0 && mesIng<13 && mesIng>0)
            {
               /* acumulador += (añoAct - añoIng) * 365;
                acumulador += (mesAct - mesIng) * 30;
                acumulador += diaAct - diaIng;*/

                for(;añoIng<añoAct;añoIng++)
                {
                    if(añoIng % 4 == 0 || añoIng % 400 == 0)
                    {
                        acumulador += 366;
                    }else
                    {
                        acumulador += 365;
                    }
                }
                acumulador += (mesAct - mesIng) * 30;
                acumulador += diaAct - diaIng;
                Console.WriteLine(acumulador);
            }
            
            Console.ReadKey();

           // Console.Write("Ingrese su fecha de nacimiento");


        }
    }
}
