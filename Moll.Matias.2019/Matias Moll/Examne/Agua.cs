using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examne
{
    public class Agua : Botella
    {
        #region Atributos
        const int MEDIDA = 400;

        #endregion

        #region Métodos
        public Agua(int capacidadML, string marca, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {
        }
        public int ServirMedida(int medida)
        {
            int retorno;
            if (medida <= Contenido)
            {
                this.Contenido = this.Contenido - medida;
                retorno = medida;
            } else
            {
                this.Contenido = 0;
                retorno = 0;
            }

            return retorno;
        }
        public override int ServirMedida()
        {
            return ServirMedida(MEDIDA);
        }
        protected new string GenerarInforme()
        {
            return base.ToString();
        }
        #endregion
    }
}
