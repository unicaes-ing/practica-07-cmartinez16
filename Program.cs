using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int mayores = 0, menores = 0;
            int edad;
            Console.WriteLine("Ingrese la cantidad de personas");
            num = Convert.ToInt32(Console.ReadLine());
            int [] cantidades= new int[num];
            for (int i =0; i < cantidades.Length; i ++)
            {
                Console.WriteLine("Ingrese la edad de la persona {0}",i+1);
                edad = Convert.ToInt32(Console.ReadLine());
                if ( edad >= 18)
                {
                    mayores = mayores + 1;
                }
                else
                {
                    menores = menores + 1;
                }
            }
            Console.WriteLine("La cantidad de mayores de edad es : "+ mayores);
            Console.WriteLine("La cantidad de menores de edad es: " + menores);
            Console.ReadKey();
        }
    }
}
