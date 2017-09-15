using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoGenerico.Dominio.Especificaciones
{
    class Jugador
    {
        String NombreJugador;
        String FichaJugador;

        public void setNombreJugador(string pNombre)
        {
            NombreJugador = pNombre;
        }
        public string getNombreJugador()
        {
            return NombreJugador;
        }

        public void setFichaJugador(String pFichaJugador)
        {
            FichaJugador = pFichaJugador; 
        }
        public string getFichaJugador()
        {
            return FichaJugador;
        }

    }
}
