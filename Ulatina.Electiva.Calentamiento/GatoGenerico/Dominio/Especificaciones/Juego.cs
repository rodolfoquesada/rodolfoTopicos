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
        int posicionLlenar;
        int turnoJugar;
        int opcionJuego;
        
        public void SetTamanoTablero(int pTamano)
        {
            this.tamanoTablero = pTamano;
        }
        public int GetTamanoTablero()
        {
            return this.tamanoTablero;
        }

        public void SetPosicionLlenar(int pPosicionLlenar)
        {
            this.posicionLlenar = pPosicionLlenar;
        }
        public int GetPosicionLlenar()
        {
            return this.posicionLlenar;
        }

        public void SetTurnoJugar(int pTurnoJugar)
        {
            this.turnoJugar = pTurnoJugar;
        }
        public int GetTurnoJugar()
        {
            return this.turnoJugar;
        }

        public void SetOpcionJuego(int pOpcionJuego)
        {
            this.opcionJuego = pOpcionJuego;
        }
        public int GetOpcionJuego()
        {
            return this.opcionJuego;
        }
    }
}
