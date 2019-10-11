using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examne
{
    public class Cantina
    {
        #region Atributos
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;
        #endregion

        #region Propiedades
        public List<Botella> Botellas
        {
            get
            {
                return botellas;
            }
        }

        #endregion

        #region Métodos
        private Cantina(int espacio)
        {
            botellas = new List<Botella>();
            espaciosTotales = espacio;
        }
        public static Cantina GetCantina(int espacios)
        {
            if (singleton is null)
            {
                singleton = new Cantina(espacios);    
            }else
            {
                singleton.espaciosTotales = espacios;
            }
            return singleton;
        }
        public static bool operator +(Cantina c, Botella b)
        {
            bool retorno = false;
            if((c.espaciosTotales - c.Botellas.Count) > 0)
            {
                c.Botellas.Add(b);
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
