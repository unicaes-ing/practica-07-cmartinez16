using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7
{
    class Ejercicio6
    {
        public static Random r;
        public static int[,] nums;

        public static void Cargar()
        {
            r = new Random();

            nums = new int[10, 10];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int c = 0; c < nums.GetLength(1); c++)
                {
                    nums[i, c] = r.Next(10, 99);
                }
            }

            Console.WriteLine();
            Console.WriteLine("La matriz se ha generado");
            Console.WriteLine("Presiones <Enter> para regresar al menu");
            Console.ReadLine();
        }

        public static void Mostrar()
        {
            Console.WriteLine("+––-+–––+–––+–––+––––+––––");
            for (int f = 0; f < nums.GetLength(0); f++)
            {
                Console.WriteLine("[");
                for (int c = 0; c < nums.GetLength(0); c++)
                {
                    if (nums[f, c] == 0)
                    {
                        Console.Write("00");
                    }
                    else
                    {
                        if ((nums[f, c] != 0) && (nums[f, c] % 2 == 0))
                        {

                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        Console.Write(nums[f, c]);
                    }

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("[");
                }
                Console.WriteLine();
                if (f < 9)
                {
                    Console.WriteLine("+––-+–––+–––+–––+––––+––––");
                }
            }
            Console.WriteLine("+––-+–––+–––+–––+––––+––––");
            Console.WriteLine();
            Console.WriteLine("Presione <Enter> para regresar al menu");
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            int op = 0;
            nums = new int[6, 6];
            do
            {
                Console.Clear();
                Console.WriteLine("[1]. Generar matriz");
                Console.WriteLine("[2]. Ver matriz");
                Console.WriteLine("[3]. Salir");
                Console.WriteLine();
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Cargar();
                        break;
                    case 2:
                        Mostrar();
                        break;
                }
            } while (op != 3);

        }
    }

}
