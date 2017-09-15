using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoGenerico.Dominio.Validaciones
{
    class Menu
    {
        public static Boolean ValidarPrimeroEnJugar(int pOpcion)
        {
            if (pOpcion != 1 && pOpcion != 2)
            {
                return false;
            }
            return true;
        }

        public static Boolean ValidarOpcionFicha(int pOpcion)
        {
            if (pOpcion != 1 && pOpcion != 2)
            {
                return false;
            }
            return true;
        }

        public static Boolean ValidarOpcionTamano(int pOpcion)
        {
            if(pOpcion != 1 && pOpcion != 2 && pOpcion != 3)
            {
                return false;
            }
            return true;
        }
    }
}
