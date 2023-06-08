using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();

        }

        public static void Ejercicio1()
        {
            int[,] arreglo = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int valor;
                    Console.WriteLine("Ingrese un número");
                    valor = int.Parse(Console.ReadLine());
                    arreglo[i, j] = valor;

                    Console.Clear();
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arreglo[i, j] + " ");
                }
                Console.WriteLine();
            }
            int total = arreglo[0, 0] + arreglo[0, 4] + arreglo[4, 0] + arreglo[4, 4];
            Console.WriteLine("La suma total de las esquinas es de " + total);
            Console.ReadKey();
        }

        // falta hacer que sume en diagonal
        public static void Ejercicio2()
        {
            int[,] arreglo = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int valor;
                    Console.WriteLine("Ingrese un número");
                    valor = int.Parse(Console.ReadLine());
                    arreglo[i, j] = valor;

                    Console.Clear();
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arreglo[i, j] + " ");
                }
                Console.WriteLine();
            }
            int total = arreglo[0, 0] + arreglo[0, 4] + arreglo[4, 0] + arreglo[4, 4];
            Console.WriteLine("La suma total de las esquinas es de " + total);
            Console.ReadKey();


          //  0,0   0,1   0,2   0,3   0,4
          //  1,0   1,1   1,2   1,3   1,4
          //  2,0   2,1   2,2   2,3   2,4
          //  3,0   3,1   3,2   3,3   3,4
          //  4,0   4,1   4,2   4,3   4,4

        }
    }
}
