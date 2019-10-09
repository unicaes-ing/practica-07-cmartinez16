using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7
{
    class Ejercicio4
    {
        public static int[,] Nums;
        public static void CargarDatos()
        {
            Nums = new int[5, 5];
            Console.WriteLine("Ingrese los numero de la matriz a generar: ");
            for ( int i =0; i < 5; i++)
            {
                for (int c = 0; c < 5; c++)
                {
                    string num;
                    num = Console.ReadLine();
                    Nums[i, c] = int.Parse(num);
                }
            }
        }

        public static void Mostrar()
        {
            for (int i = 0; i < 5; i++)
            {
                for ( int c = 0; c < 5; c++)
                {
                    Console.Write(Nums[i,c]+"");
                }
            }
            Console.WriteLine();
        }

        static void Main (string[]args)
        {
            CargarDatos();
            Mostrar();
            Console.ReadKey();
        }
    }
}
