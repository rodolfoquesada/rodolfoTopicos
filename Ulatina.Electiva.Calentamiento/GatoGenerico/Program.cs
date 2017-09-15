using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatoGenerico.Dominio.Especificaciones;
using GatoGenerico.Dominio.Acciones;

namespace GatoGenerico
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador();
            Juego juego1 = new Juego();
            int ficha = 0;
            int tamano = 0;
            int primeroJugar = 0;
            String[] tablero = new String[0];

            MetodosGenerales.DesplegarMenu(jugador1, jugador2, ficha, juego1, primeroJugar);
            tablero = MetodosGenerales.CrearTablero(juego1.getTamanoTablero(), tablero);
            MetodosGenerales.DesplegarTablero(tablero, juego1.getTamanoTablero());
            System.Threading.Thread.Sleep(600000);
            Console.Clear();
        }    
    }
}
