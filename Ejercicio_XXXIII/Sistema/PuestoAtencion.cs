using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sistema
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                return numeroActual + 1;
            }
        }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        
        public bool Atender(Cliente cl)
        {
            bool retorno = false;
            Thread.Sleep(2000);
            retorno = true;
            return retorno;
            
        }
    }
}
