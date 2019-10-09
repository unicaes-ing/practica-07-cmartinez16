using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int num;
            int pares = 0, impares = 0;
            int n;
            Console.WriteLine("Ingrese la cantidad de numeros a evaluar");
            num = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[num];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un numero");
                n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }
            }
            Console.WriteLine("La cantidad de numeros pares es : " + pares);
            Console.WriteLine("La cantidad de numeros impares es: " + impares);
            Console.ReadKey();
        }
    }
}
