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
        public static void DesplegarMenu(Jugador jugador1, Jugador jugador2, Juego pJuego)
        {
            Console.WriteLine("Nombre del primer jugador:");
            Console.WriteLine("------------------------------------");
            jugador1.SetNombreJugador(Console.ReadLine());
            Console.Clear();
            do
            {
                Console.WriteLine("Seleccione ficha?, Digite:");
                Console.WriteLine("1. Jugar con 'X'");
                Console.WriteLine("2. Jugar con '0'");
                Console.WriteLine("------------------------------------");
                jugador1.SetFicha(Convert.ToInt32(Console.ReadLine()));
                Console.Clear();
            } while (!Menu.ValidarOpcionFicha(jugador1.GetFicha()));
            Console.WriteLine("Nombre del segundo jugador:");
            Console.WriteLine("------------------------------------");
            jugador2.SetNombreJugador(Console.ReadLine());
            Console.Clear();
            do
            {
                Console.WriteLine("Primero en jugar? Digite:");
                Console.WriteLine("1. jugador 1");
                Console.WriteLine("2. jugador 2");
                Console.WriteLine("------------------------------------");
                jugador1.SetJugada(Convert.ToInt32(Console.ReadLine()));
                Console.Clear();
            } while (!Menu.ValidarPrimeroEnJugar(jugador1.GetJugada()));
            if (jugador1.GetJugada().Equals(1))
            {
                jugador2.SetJugada(2);
            }
            else
            {
                jugador2.SetJugada(1);
            }
            pJuego.SetTurnoJugar(1);
            do
            {
                Console.WriteLine("Seleccione el tamaño de la cuadricula:");
                Console.WriteLine("1. Tamaño de 3X3");
                Console.WriteLine("2. Tamaño de 4X4");
                Console.WriteLine("3. Tamaño de 5X5");
                Console.WriteLine("------------------------------------");
                pJuego.SetTamanoTablero( Convert.ToInt32(Console.ReadLine()));
                Console.Clear();
            } while (!Menu.ValidarOpcionTamano(pJuego.GetTamanoTablero()));
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

        public static void DesplegarTablero(String[] tablero, int pTamano, Juego pJuego1, Jugador pJugador1, Jugador pJugador2)
        {
            if (pTamano.Equals(1))
            {
                Console.WriteLine("\n     " + tablero[0] + " | " + tablero[1] + "  | " + tablero[2]);
                Console.WriteLine("\n   ___  ___  ___");
                Console.WriteLine("\n     " + tablero[3] + " | " + tablero[4] + "  | " + tablero[5]);
                Console.WriteLine("\n   ___  ___  ___");
                Console.WriteLine("\n     " + tablero[6] + " | " + tablero[7] + "  | " + tablero[8]);
            }else if (pTamano.Equals(2))
            {
                Console.WriteLine("\n     " + tablero[0] + " | " + tablero[1] + "  | " + tablero[2] + "  | " + tablero[3]);
                Console.WriteLine("\n   ___  ___  ___  ___");
                Console.WriteLine("\n     " + tablero[4] + " | " + tablero[5] + "  | " + tablero[6] + "  | " + tablero[7]);
                Console.WriteLine("\n   ___  ___  ___  ___");
                Console.WriteLine("\n     " + tablero[8] + " | " + tablero[9] + "  | " + tablero[10] + "  | " + tablero[11]);
                Console.WriteLine("\n   ___  ___  ___  ___");
                Console.WriteLine("\n     " + tablero[12] + " | " + tablero[13] + "  | " + tablero[14] + "  | " + tablero[15]);
            }else if (pTamano.Equals(3))
            {
                Console.WriteLine("\n     " + tablero[0] + " | " + tablero[1] + "  | " + tablero[2] + "  | " + tablero[3] + "  | " + tablero[4]);
                Console.WriteLine("\n   ___  ___  ___  ___  ___");
                Console.WriteLine("\n     " + tablero[5] + " | " + tablero[6] + "  | " + tablero[7] + "  | " + tablero[8] + "  | " + tablero[9]);
                Console.WriteLine("\n   ___  ___  ___  ___  ___");
                Console.WriteLine("\n     " + tablero[10] + " | " + tablero[11] + "  | " + tablero[12] + "  | " + tablero[13] + "  | " + tablero[14]);
                Console.WriteLine("\n   ___  ___  ___  ___  ___");
                Console.WriteLine("\n     " + tablero[15] + " | " + tablero[16] + "  | " + tablero[17] + "  | " + tablero[18] + "  | " + tablero[19]);
                Console.WriteLine("\n   ___  ___  ___  ___  ___");
                Console.WriteLine("\n     " + tablero[20] + " | " + tablero[21] + "  | " + tablero[22] + "  | " + tablero[23] + "  | " + tablero[24]);
            }
            if (pJuego1.GetTurnoJugar().Equals(pJugador1.GetJugada()))
            {
                Console.WriteLine($"Turno de jugador: {pJugador1.GetNombreJugador()}");
            }
            else
            {
                Console.WriteLine($"Turno de jugador: {pJugador2.GetNombreJugador()}");
            }
            Console.WriteLine("Seleccione posicion a llenar:");
            pJuego1.SetPosicionLlenar(Convert.ToInt32(Console.ReadLine()));
        }

        public static void AsignarFicha(Jugador pJugador1, Jugador pJugador2)
        {
            if (pJugador1.GetFicha().Equals(1))
            {
                pJugador1.SetFichaJugador("X");
                pJugador2.SetFichaJugador("0");
            }
            else
            {
                pJugador1.SetFichaJugador("0");
                pJugador2.SetFichaJugador("X");
            }
        }

        public static void DesplegarIndicacionesJuego(Jugador pJugador1, Jugador pJugador2)
        {
            Console.WriteLine("Bienvenido al Juego de Gato");
            Console.WriteLine($"Nombre Jugador 1: {pJugador1.GetNombreJugador()}");
            Console.WriteLine($"Ficha Asignada: {pJugador1.GetFichaJugador()}");
            Console.WriteLine($"Turno de Jugar: {pJugador1.GetJugada()}");
            Console.WriteLine("");
            Console.WriteLine($"Nombre Jugador 2: {pJugador2.GetNombreJugador()}");
            Console.WriteLine($"Ficha Asignada: {pJugador2.GetFichaJugador()}");
            Console.WriteLine($"Turno de Jugar: {pJugador2.GetJugada()}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Pulse cualquier tecla para iniciar el juego...");
            Console.ReadLine();
        }

        public static Boolean LlenarTablero(String[] tablero, Jugador pJugador1, Jugador pJugador2, Juego pJuego)
        {
            if(Tablero.ValidarPosicionLlenar(tablero, pJuego))
            {
                if (pJuego.GetTurnoJugar().Equals(pJugador1.GetJugada()))
                {
                    tablero[pJuego.GetPosicionLlenar() - 1] = pJugador1.GetFichaJugador();
                    pJuego.SetTurnoJugar(pJuego.GetTurnoJugar() + 1);
                }
                else
                {
                    tablero[pJuego.GetPosicionLlenar() - 1] = pJugador2.GetFichaJugador();
                    pJuego.SetTurnoJugar(pJuego.GetTurnoJugar() - 1);
                }
                return true;
            }
            return false;
        }

        public static void Jugar(String[] tablero, Jugador pJugador1, Jugador pJugador2, Juego pJuego)
        {
            Boolean salir = false;
            do
            {
                if (!Tablero.ValidarTableroLleno(tablero))
                {
                    DesplegarTablero(tablero, pJuego.GetTamanoTablero(), pJuego, pJugador1, pJugador2);
                    if (Tablero.ValidarPosicionLlenar(tablero, pJuego))
                    {
                        LlenarTablero(tablero, pJugador1, pJugador2, pJuego);
                        if(Ganador.ValidarGanador(tablero, pJugador1, pJuego) || Ganador.ValidarGanador(tablero, pJugador2, pJuego))
                        {
                            Console.Clear();
                            if (pJuego.GetGanadorJuego().Equals(pJugador1.GetJugada()))
                            {
                                Console.WriteLine($"{pJugador1.GetNombreJugador()} Felicidades!!! HAS GANADO EL JUEGO... [PRESIONE ENTER PARA CONTINUAR]");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine($"{pJugador2.GetNombreJugador()} Felicidades!!! HAS GANADO EL JUEGO... [PRESIONE ENTER PARA CONTINUAR]");
                                Console.ReadLine();
                            }
                            Console.Clear();
                            DesplegarOpcionesJuego(pJuego);
                            if (pJuego.GetOpcionJuego().Equals(1))
                            {
                                Tablero.LimpiarTablero(tablero);
                            }
                            else
                            {
                                salir = true;
                            }
                        }
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error! la posicion seleccionada no existe o ya se encuentra ocupada... " +
                            "Por favor seleccionar una posición valida [PRESIONE ENTER PARA CONTINUAR]");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("El tablero está lleno!!! Juego Empatado [PRESIONE ENTER PARA CONTINUAR]");
                    Console.ReadLine();
                    Console.Clear();
                    DesplegarOpcionesJuego(pJuego);
                    if (pJuego.GetOpcionJuego().Equals(1))
                    {
                        Tablero.LimpiarTablero(tablero);
                    }
                    else
                    {
                        salir = true;
                    }
                }
            } while (salir == false);
        }

        public static void DesplegarOpcionesJuego(Juego pJuego)
        {
            Console.WriteLine("Seleccione la opcion deseada");
            Console.WriteLine("1. Reiniciar Juego");
            Console.WriteLine("2. Juego Nuevo");
            Console.WriteLine("3. Salir");
            pJuego.SetOpcionJuego(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();
        }
    }
}
