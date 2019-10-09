using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int numequipos, numjugadores;
            Console.WriteLine("Ingrese la cantidad de equipos participantes");
            numequipos = Convert.ToInt32(Console.ReadLine());

            string[][] equipos = new string[numequipos][];
            for (int i = 0; i < equipos.Length; i++)
            {
                Console.WriteLine("Escriba la cantidad de jugadores que tiene el equipo " + (i + 1) + ":");
                numjugadores = Convert.ToInt32(Console.ReadLine());
                equipos[i] = new string[numjugadores];
                for ( int c = 0; c < equipos[i].Length; c++)
                {
                    Console.WriteLine("Escriba el nombre del jugador "+ (c+1) + ":");
                    equipos[i][c] = Console.ReadLine();
                }

            }
            Console.ReadKey();
        }
    }
}
