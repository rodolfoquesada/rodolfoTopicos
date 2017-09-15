using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoGenerico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre del primer jugador:");
            String nombre1 = Console.ReadLine();
            Console.WriteLine("Nombre del segundo jugador:");
            String nombre2 = Console.ReadLine();
            Console.WriteLine("Primero en jugar? Digite:");
            Console.WriteLine("1. Jugador con 'X'");
            Console.WriteLine("2. Jugador con '0'");
            int PrimeroJugar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seleccione el tamaño de la cuadricula:");
            Console.WriteLine("1. Tamaño de 3X3");
            Console.WriteLine("2. Tamaño de 4X4");
            Console.WriteLine("3. Tamaño de 5X5");
            int Tamaño = Convert.ToInt32(Console.ReadLine());
        }
    }
}
