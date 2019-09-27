using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Clientes
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                if(this != value)
                {
                    clientes.Enqueue(value);
                }
            }
        }


        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);

        }

        public static bool operator == (Negocio n, Cliente c)
        {
            bool retorno = false;
            if(!(n is null) && !(c is null))
            {
                if (n.clientes.Contains(c))
                {
                    retorno = true;
                }

            }
            return retorno;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if(!(n is null) && !(c is null))
            {
                if (n != c)
                {
                    n.clientes.Enqueue(c);
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if(!(n is null))
            {
                Cliente aux = n.Clientes;
                if (!(aux is null))
                {
                    
                    retorno = n.caja.Atender(aux); 
                }
            }
            return retorno;
        }
    }
}
