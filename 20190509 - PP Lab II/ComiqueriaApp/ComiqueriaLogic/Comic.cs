using System;
using System.Collections.Generic;
using System.Text;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        #region Enumerado
        public enum TipoComic
        {
            Occidental,
            Oriental
        }
        #endregion

        #region Atributos
        private string autor;
        private TipoComic tipoComic;
        #endregion

        #region Constructores / Metodos
        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipo)
            : base(descripcion,stock,precio)
        {
            this.autor = autor;
            tipoComic = tipo;
        }
        public override string ToString()
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendLine(base.ToString());
            salida.AppendFormat("Autor: {0}\r\nTipo de Comic: {1}\r\n", this.autor, this.tipoComic);
            return salida.ToString();
        }
        #endregion
    }
}
