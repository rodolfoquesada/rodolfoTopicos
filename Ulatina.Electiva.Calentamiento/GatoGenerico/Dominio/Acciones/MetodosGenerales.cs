using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatoGenerico.Dominio.Especificaciones;
using GatoGenerico.Dominio.Validaciones;

namespace GatoGenerico.Dominio.Acciones
{
    class MetodosGenerales
    {
        public static void DesplegarMenu(Jugador jugador1, Jugador jugador2, int pFicha,
            Juego pJuego, int pPrimeroJugar)
        {
            Console.WriteLine("Nombre del primer jugador:");
            jugador1.setNombreJugador(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.Clear();
            do
            {
                Console.WriteLine("Seleccione ficha?, Digite:");
                Console.WriteLine("1. Jugar con 'X'");
                Console.WriteLine("2. Jugar con '0'");
                pFicha = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------------");
                Console.Clear();
            } while (!Menu.ValidarOpcionFicha(pFicha));
            Console.WriteLine("Nombre del segundo jugador:");
            jugador2.setNombreJugador(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.Clear();
            do
            {
                Console.WriteLine("Primero en jugar? Digite:");
                Console.WriteLine("1. jugador 1");
                Console.WriteLine("2. jugador 2");
                pPrimeroJugar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------------");
                Console.Clear();
            } while (!Menu.ValidarPrimeroEnJugar(pPrimeroJugar));

            do
            {
                Console.WriteLine("Seleccione el tamaño de la cuadricula:");
                Console.WriteLine("1. Tamaño de 3X3");
                Console.WriteLine("2. Tamaño de 4X4");
                Console.WriteLine("3. Tamaño de 5X5");
                pJuego.setTamanoTablero( Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("------------------------------------");
                Console.Clear();
            } while (!Menu.ValidarOpcionTamano(pJuego.getTamanoTablero()));
        }

         public static String[] CrearTablero(int pTamano, String[] tablero)
        {
            if (pTamano.Equals(1))
            {
                tablero = new String[9];
            }else if (pTamano.Equals(2))
            {
                tablero = new String[16];
            }
            else
            {
                tablero = new String[25];
            }
            return tablero;
        }

        public static void DesplegarTablero(String[] tablero, int pTamano)
        {
            var nuevoTab = new string[tablero.Length];
            tablero.CopyTo(nuevoTab, 0);
            for (int i = 0; i <= (pTamano*pTamano); i++)
            {
                if (nuevoTab[i] == null)
                {
                    int x = i + 1;
                    nuevoTab[i] = Convert.ToString(x);
                }
            }
            if (pTamano.Equals(1))
            {
                Console.WriteLine("\n     " + nuevoTab[0] + " | " + nuevoTab[1] + "  | " + nuevoTab[2]);
                Console.WriteLine("\n   ___  ___  ___");
                Console.WriteLine("\n     " + nuevoTab[3] + " | " + nuevoTab[4] + "  | " + nuevoTab[5]);
                Console.WriteLine("\n   ___  ___  ___");
                Console.WriteLine("\n     " + nuevoTab[6] + " | " + nuevoTab[7] + "  | " + nuevoTab[8]);
            }else if (pTamano.Equals(2))
            {
                Console.WriteLine("\n     " + nuevoTab[0] + " | " + nuevoTab[1] + "  | " + nuevoTab[2] + "  | " + nuevoTab[3]);
                Console.WriteLine("\n   ___  ___  ___");
                Console.WriteLine("\n     " + nuevoTab[4] + " | " + nuevoTab[5] + "  | " + nuevoTab[6] + "  | " + nuevoTab[7]);
                Console.WriteLine("\n   ___  ___  ___");
                Console.WriteLine("\n     " + nuevoTab[8] + " | " + nuevoTab[9] + "  | " + nuevoTab[10] + "  | " + nuevoTab[11]);
                Console.WriteLine("\n   ___  ___  ___");
                Console.WriteLine("\n     " + nuevoTab[12] + " | " + nuevoTab[13] + "  | " + nuevoTab[14] + "  | " + nuevoTab[15]);
            }else if (pTamano.Equals(3))
            {
                Console.WriteLine("\n     " + nuevoTab[0] + " | " + nuevoTab[1] + "  | " + nuevoTab[2] + "  | " + nuevoTab[3] + "  | " + nuevoTab[4]);
                Console.WriteLine("\n   ___  ___  ___");
                Console.WriteLine("\n     " + nuevoTab[5] + " | " + nuevoTab[6] + "  | " + nuevoTab[7] + "  | " + nuevoTab[8] + "  | " + nuevoTab[9]);
                Console.WriteLine("\n   ___  ___  ___");
                Console.WriteLine("\n     " + nuevoTab[10] + " | " + nuevoTab[11] + "  | " + nuevoTab[12] + "  | " + nuevoTab[13] + "  | " + nuevoTab[14]);
                Console.WriteLine("\n   ___  ___  ___");
                Console.WriteLine("\n     " + nuevoTab[15] + " | " + nuevoTab[16] + "  | " + nuevoTab[17] + "  | " + nuevoTab[18] + "  | " + nuevoTab[19]);
                Console.WriteLine("\n   ___  ___  ___");
                Console.WriteLine("\n     " + nuevoTab[20] + " | " + nuevoTab[21] + "  | " + nuevoTab[22] + "  | " + nuevoTab[23] + "  | " + nuevoTab[24]);
            }
            

            
        }
    }
}
