using System;
using System.Collections.Generic;
using System.Text;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        #region Atributos
        private double altura;
        #endregion

        #region Constructores / Metodos
        public Figura(int stock, double precio, double altura)
            : this("Figura: "+altura+"cm",stock,precio,altura)
        {

        }
        public Figura(string descripcion, int stock, double precio, double altura)
            :base(descripcion,stock,precio)
        {
            this.altura = altura;
        }

        public override string ToString()
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendLine(base.ToString());
            salida.AppendFormat("Altura: {0}", this.altura);

            return salida.ToString();
        }
        #endregion



    }
}
