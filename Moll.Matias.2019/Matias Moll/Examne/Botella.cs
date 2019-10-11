using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examne
{
    public abstract class Botella
    {
        #region Atributos
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;
        #endregion

        #region Enumerado
        public enum Tipo
        {
            Plastico,
            Vidrio
        }
        #endregion

        #region Propiedades
        public int CapacidadLitros
        {
            get
            {
                return capacidadML / 1000;
            }
        }
        public int Contenido
        {
            get
            {
                return contenidoML;
            }
            set
            {
                if (value > 0)
                {
                    contenidoML = value;
                }
            }
        }
        public float PorcentajeContenido
        {
            get
            {
                return (contenidoML * 100) / capacidadML; 
            }

        }
        #endregion

        #region  Contrusctores/Mètodos
        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            this.capacidadML = capacidadML;
            this.contenidoML = contenidoML;
        }
        protected string GenerarInforme()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Marca: {0} Capacidad: {1} Contenido: {2}", this.marca, this.capacidadML, this.contenidoML);

            return retorno.ToString();
        }
        public abstract int ServirMedida();

        public override string ToString()
        {
            return this.GenerarInforme();
        }

        #endregion
    }
}
