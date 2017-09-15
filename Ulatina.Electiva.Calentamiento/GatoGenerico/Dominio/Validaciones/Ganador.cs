using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatoGenerico.Dominio.Especificaciones;

namespace GatoGenerico.Dominio.Validaciones
{
    class Ganador
    {
        public static Boolean ValidarGanador(String[] tablero, Jugador pJugador, Juego pJuego)
        {
           if( ValidarHorizontales(tablero, pJugador, pJuego))
            {
                return true;
            }
            return false;
        }

        private static Boolean ValidarHorizontales(String[] tablero, Jugador pJugador, Juego pJuego)
        {
            if (pJuego.GetTamanoTablero().Equals(1))
            {
                if(tablero[0] == pJugador.GetFichaJugador() && tablero[1] == pJugador.GetFichaJugador()
                    && tablero[2] == pJugador.GetFichaJugador())
                {
                    pJuego.SetGanadorJuego(pJugador.GetJugada());
                    return true;
                }else if(tablero[3] == pJugador.GetFichaJugador() && tablero[4] == pJugador.GetFichaJugador()
                    && tablero[5] == pJugador.GetFichaJugador()) {
                    pJuego.SetGanadorJuego(pJugador.GetJugada());
                    return true;
                }
                else if (tablero[6] == pJugador.GetFichaJugador() && tablero[7] == pJugador.GetFichaJugador()
                    && tablero[8] == pJugador.GetFichaJugador())
                {
                    pJuego.SetGanadorJuego(pJugador.GetJugada());
                    return true;
                }
            }else if (pJuego.GetTamanoTablero().Equals(2))
            {
                if (tablero[0] == pJugador.GetFichaJugador() && tablero[1] == pJugador.GetFichaJugador()
                    && tablero[2] == pJugador.GetFichaJugador() && tablero[3] == pJugador.GetFichaJugador())
                {
                    pJuego.SetGanadorJuego(pJugador.GetJugada());
                    return true;
                }
                else if (tablero[4] == pJugador.GetFichaJugador() && tablero[5] == pJugador.GetFichaJugador()
                    && tablero[6] == pJugador.GetFichaJugador() && tablero[7] == pJugador.GetFichaJugador())
                {
                    pJuego.SetGanadorJuego(pJugador.GetJugada());
                    return true;
                }
                else if (tablero[8] == pJugador.GetFichaJugador() && tablero[9] == pJugador.GetFichaJugador()
                    && tablero[10] == pJugador.GetFichaJugador() && tablero[11] == pJugador.GetFichaJugador())
                {
                    pJuego.SetGanadorJuego(pJugador.GetJugada());
                    return true;
                }
                else if (tablero[12] == pJugador.GetFichaJugador() && tablero[13] == pJugador.GetFichaJugador()
                    && tablero[14] == pJugador.GetFichaJugador() && tablero[15] == pJugador.GetFichaJugador())
                {
                    pJuego.SetGanadorJuego(pJugador.GetJugada());
                    return true;
                }
            }
            else if (pJuego.GetTamanoTablero().Equals(3))
            {
                if (tablero[0] == pJugador.GetFichaJugador() && tablero[1] == pJugador.GetFichaJugador()
                    && tablero[2] == pJugador.GetFichaJugador() && tablero[3] == pJugador.GetFichaJugador()
                    && tablero[4] == pJugador.GetFichaJugador())
                {
                    pJuego.SetGanadorJuego(pJugador.GetJugada());
                    return true;
                }
                else if (tablero[5] == pJugador.GetFichaJugador() && tablero[6] == pJugador.GetFichaJugador()
                    && tablero[7] == pJugador.GetFichaJugador() && tablero[8] == pJugador.GetFichaJugador()
                    && tablero[9] == pJugador.GetFichaJugador())
                {
                    pJuego.SetGanadorJuego(pJugador.GetJugada());
                    return true;
                }
                else if (tablero[10] == pJugador.GetFichaJugador() && tablero[11] == pJugador.GetFichaJugador()
                    && tablero[12] == pJugador.GetFichaJugador() && tablero[13] == pJugador.GetFichaJugador()
                    && tablero[14] == pJugador.GetFichaJugador())
                {
                    pJuego.SetGanadorJuego(pJugador.GetJugada());
                    return true;
                }
                else if (tablero[15] == pJugador.GetFichaJugador() && tablero[16] == pJugador.GetFichaJugador()
                    && tablero[17] == pJugador.GetFichaJugador() && tablero[18] == pJugador.GetFichaJugador()
                    && tablero[19] == pJugador.GetFichaJugador())
                {
                    pJuego.SetGanadorJuego(pJugador.GetJugada());
                    return true;
                }
                else if (tablero[20] == pJugador.GetFichaJugador() && tablero[21] == pJugador.GetFichaJugador()
                    && tablero[22] == pJugador.GetFichaJugador() && tablero[23] == pJugador.GetFichaJugador()
                    && tablero[24] == pJugador.GetFichaJugador())
                {
                    pJuego.SetGanadorJuego(pJugador.GetJugada());
                    return true;
                }
            }
            return false;
        }

        private static Boolean ValidarVerticales(String[] tablero, Jugador pJugador, Juego pJuego)
        {
            
        }
    }
}
