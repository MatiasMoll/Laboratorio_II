using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examne
{
    public class Cerveza : Botella
    {
        #region Atributos
        const int MEDIDA = 330;
        private Tipo tipo;
        #endregion

        #region Constructores/Métodos
        public Cerveza(int capacidadML, string marca, int contenidoML)
            : this(capacidadML,marca,Tipo.Vidrio,contenidoML)
        {
        }
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML)
            : base(marca,capacidadML,contenidoML)
        {
            this.tipo = tipo;
        }
        protected new string GenerarInforme()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("{0} Tipo: {1}", base.ToString(), this.tipo);
            return retorno.ToString();
        }
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
        public override int ServirMedida()
        {
            int retorno;
            if ((MEDIDA / 1000) <= Contenido)
            {
                retorno = Contenido - ((((MEDIDA) * 80) / 100) / 1000);
            } else
            {
                retorno = Contenido;
            }
            return retorno;
        }
        #endregion
    }
}
