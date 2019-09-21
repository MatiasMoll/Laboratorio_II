using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }
        
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        protected virtual string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append("Duracion: "+this.duracion+" ");
            cadena.Append("Numero Origen: " + this.nroOrigen + " ");
            cadena.Append("Numero Destino: " + this.nroDestino + " ");
            return cadena.ToString();
        }
        public static int OrdenarLlamada(Llamada l1, Llamada l2)
        {
            int retorno = -2;
            if(l1.duracion > l2.duracion)
            {
                retorno = -1;
            }else if(l1.duracion < l2.duracion)
            {
                retorno = 1;
            }else
            {
                retorno = 0;
            }
            return retorno;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;
            if(l1.Equals(l2) && l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen)
            { 
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

    }
}  
