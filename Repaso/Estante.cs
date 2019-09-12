using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
            
        public Estante(int ubicacion, int capacidad):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public string MostrarEstantes(Estante e)
        {
            string products = "";
            for (int i = 0; i < e.GetProductos().Length; i++)
            {
                if (!(e.productos[i] is null))
                {
                    products +="-" + productos[i].MostrarProducto() + "\n";
                }
                else
                    continue;
            }
            return string.Format("Productos del estante {0}: \n{1}",e.ubicacionEstante,products);
        }
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            for(int i=0;i<e.GetProductos().Length;i++)
            {
                if (!(e.productos[i] is null))
                {
                    if (e.productos[i] == p)
                    {
                        retorno = true;
                    }
                }
                else
                    continue;
            }
            return retorno;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            if(e != p)
            { 
                for(int i=0;i<e.GetProductos().Length;i++)
                {   
                    if (e.productos[i] is null)
                    {
                        e.productos.SetValue(p, i);
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }


    }
}
