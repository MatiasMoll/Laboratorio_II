using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class UnaExcepcion : Exception
    {
        public UnaExcepcion(string msg, Exception e):base(msg,e)
        {

        }
    }
}
