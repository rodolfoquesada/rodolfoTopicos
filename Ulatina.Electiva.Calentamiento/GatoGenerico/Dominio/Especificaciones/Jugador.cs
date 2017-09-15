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
        int Jugada;
        int Ficha;

        public void SetNombreJugador(string pNombre)
        {
            this.NombreJugador = pNombre;
        }
        public string GetNombreJugador()
        {
            return this.NombreJugador;
        }

        public void SetFichaJugador(String pFichaJugador)
        {
            this.FichaJugador = pFichaJugador; 
        }
        public string GetFichaJugador()
        {
            return this.FichaJugador;
        }

        public void SetJugada(int pJugada)
        {
            this.Jugada = pJugada; 
        }
        public int GetJugada()
        {
            return this.Jugada;
        }

        public void SetFicha(int pFicha)
        {
            this.Ficha = pFicha;
        }
        public int GetFicha()
        {
            return this.Ficha;
        }
    }
}
