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
            String[] tablero = new String[0];
            do
            {
                MetodosGenerales.DesplegarMenu(jugador1, jugador2, juego1);
                MetodosGenerales.AsignarFicha(jugador1, jugador2);
                tablero = MetodosGenerales.CrearTablero(juego1.GetTamanoTablero(), tablero);
                MetodosGenerales.DesplegarIndicacionesJuego(jugador1, jugador2);
                Console.Clear();
                MetodosGenerales.Jugar(tablero, jugador1, jugador2, juego1);
            } while (juego1.GetOpcionJuego().Equals(2));
            Console.WriteLine("Saliendo del Juego...!!!!");
            System.Threading.Thread.Sleep(2000);
        }    
    }
}
