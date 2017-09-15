using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatoGenerico.Dominio.Especificaciones;

namespace GatoGenerico.Dominio.Validaciones
{
    class Tablero
    {
        public static Boolean ValidarPosicionLlenar(String[] tablero, Juego pJuego)
        {
            int p = pJuego.GetPosicionLlenar()-1;
            int ultimaPosicion = tablero.Length;
            if(p < ultimaPosicion)
            {
                if (tablero[p] == null)
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean ValidarTableroLleno(String[] tablero)
        {
            int tam = tablero.Length;
            for (int i = 0; i < tam; i++)
            {
                if (tablero[i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        public static void LimpiarTablero(String[] tablero)
        {
            int tam = tablero.Length;
            for (int i = 0; i < tam; i++)
            {
                tablero[i] = null;
            }
        }
    }
    
}
