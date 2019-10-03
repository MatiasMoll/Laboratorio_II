using System;
using System.Text;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        #region Atributos
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;
        #endregion

        #region Propiedades
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
        }
        public double Precio
        {
            get
            {
                return precio;
            }
        }
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if(value >= 0)
                {
                    stock = value;
                }
                
            }
        }

        #endregion

        #region Constructor / Metodos
        protected Producto(string descripcion, int stock, double precio)
        {
            this.stock = stock;
            this.precio = precio;
            this.descripcion = descripcion;
            this.codigo = Guid.NewGuid();
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        public override string ToString()
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendFormat("Descripcion: {0}\r\n", this.descripcion);
            salida.AppendFormat("Codigo: {0}\r\n", (Guid)this);
            salida.AppendFormat("Precio: {0}\r\n", this.precio);
            salida.AppendFormat("Stock: {0}\r\n", this.stock);

            return salida.ToString();
        }
        #endregion
    }
}
