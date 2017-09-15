using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoGenerico.Dominio.Especificaciones
{
    class Juego
    {
        int tamanoTablero;
        
        public void setTamanoTablero(int pTamano)
        {
            tamanoTablero = pTamano;
        }

        public int getTamanoTablero()
        {
            return tamanoTablero;
        }
    }
}
