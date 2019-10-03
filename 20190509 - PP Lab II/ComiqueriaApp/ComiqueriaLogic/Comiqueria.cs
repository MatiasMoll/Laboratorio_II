using System;
using System.Collections.Generic;
using System.Text;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        #region Atributos
        private List<Producto> productos;
        private List<Venta> ventas;
        #endregion

        #region Propiedades
        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto producto in productos)
                {
                    if ((Guid)producto == codigo)
                    {
                        return producto;
                    }
                }
                return null;
            }
        }
        #endregion

        #region Constructor / Metodo
        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
        public static bool operator ==(Comiqueria comiqueria,Producto producto)
        {
            bool retorno = false;
            if(!(comiqueria is null) && !(producto is null))
            {
                foreach(Producto product in comiqueria.productos)
                {
                    if(product.Descripcion == producto.Descripcion)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;

        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            Comiqueria retorno = comiqueria;
            if(!(comiqueria is null) && !(producto is null))
            {
                if(comiqueria!=producto)
                {
                    retorno.productos.Add(producto);
                }

            }
            return retorno;
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta venta = new Venta(producto, cantidad);
            this.ventas.Add(venta);
        }
        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }
        public string ListarVentas()
        {
            StringBuilder retorno = new StringBuilder();
            ventas.Sort(OrdenarPorFecha);
            foreach(Venta v in this.ventas)
            {
                retorno.AppendLine(v.ObtenerDescripcionBreve());
            }
            return retorno.ToString();
        }
        private int OrdenarPorFecha(Venta v1, Venta v2)
        {
            int retorno = 0;
            if(v1.Fecha < v2.Fecha)
            {
                retorno = 1;
            }else if(v1.Fecha > v2.Fecha)
            {
                retorno = -1;
            }
            return retorno;
        }
        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> retorno = new Dictionary<Guid, string>();
            foreach(Producto p in productos)
            {
                retorno.Add((Guid)p, p.Descripcion);
            }
            return retorno;
        }
        #endregion
    }
}
