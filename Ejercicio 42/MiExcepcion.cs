using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class MiExcepcion : Exception
    {
        public MiExcepcion(string msg, Exception e):base(msg,e)
        {

        }
    }
}
