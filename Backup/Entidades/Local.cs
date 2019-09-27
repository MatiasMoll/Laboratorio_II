using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        
        protected new string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(base.Mostrar()+" Costo de llamada: " + CostoLlamada);
            return cadena.ToString();
        }
        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
            
        }

        public Local(string origen,float duracion, string destino,float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(!(obj is null))
            {
                if (obj is Local)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
