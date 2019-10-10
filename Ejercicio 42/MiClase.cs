using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class MiClase 
    { 
        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch (DivideByZeroException e)
            {
                throw new DivideByZeroException("Primer Constructor");
            }

        }
        public MiClase(string asd)
        {

        }
        public MiClase(int asd)
        {
            try
            {
                MiClase aux = new MiClase();
            }
            catch(DivideByZeroException e)
            {
                throw new UnaExcepcion("Constructor con parametros",e); 
            }
        }

        public void MetodoInsancia()
        {
            try
            {
                MiClase aux = new MiClase(2);
            }catch(UnaExcepcion e)
            {
                throw new MiExcepcion("Metodo Instancia", e);
            }
        }

        static void MetodoEstatico()
        {
            throw new DivideByZeroException("Metodo Estatico");
        }

    }


}   
