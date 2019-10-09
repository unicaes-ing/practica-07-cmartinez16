using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7
{
    class Ejercicio5
    {
        public static int[,] Nums;
        public static int[,] Nums2;

        static int Suma(int[,] datos)
        {
            int sumar = 0;

            for (int m = 0; m < datos.GetLength(0); m++)
            {
                for (int f = 0; f < datos.GetLength(1); f++)
                {
                    sumar += datos[m, f];
                }
            }
            return sumar;
        }

        static int suma2(int[,] datos)
        {
            int sumar = 0;

            for (int m = 0; m < datos.GetLength(0); m++)
            {
                for (int f = 0; f < datos.GetLength(1); f++)
                {
                    sumar += datos[m, f];
                }
            }
            return sumar;
        }

        static void Main(string[] args)
        {
            int resultado = 0;
            Nums = new int[3, 3];
            Console.WriteLine("Ingrese los numeros de la primera matriz: ");
            for (int mm = 0; mm < Nums.GetLength(0); mm++)
            {
                for (int ff = 0; ff < Nums.GetLength(1); ff++)
                {
                    string num;
                    num = Console.ReadLine();
                    Nums[mm, ff] = int.Parse(num);
                }
            }

            Nums2 = new int[3, 3];
            Console.WriteLine("Ingrese los numeros de la segunda matriz: ");
            for (int m2 = 0; m2 < Nums.GetLength(0); m2++)
            {
                for (int f2 = 0; f2 < Nums.GetLength(1); f2++)
                {
                    string num;
                    num = Console.ReadLine();
                    Nums2[m2, f2] = int.Parse(num);
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Clear();
            resultado = Suma(Nums) + Suma(Nums2);
            Console.WriteLine("La suma de ambas matrices es: {0:N0}", resultado);
            Console.ReadKey();
        }

    }
}
