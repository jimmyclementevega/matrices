using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nfilas, ncolum;
            int[,] numero;

            Console.WriteLine("ingrese la cantidad de filas: ");
            nfilas = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero de colunas: ");
            ncolum = int.Parse(Console.ReadLine());
            numero = new int[nfilas, ncolum];
            //ingresar elementos
            Console.WriteLine("ingres los elementos a la matriz");
            for (int i = 0; i < nfilas; i++)//filas
            {
                for (int j = 0; j < ncolum; j++)//columnas
                {
                    Console.Write("ingrese el valor "+"["+i+"]"+"["+j+"] :");
                    numero[i, j] = int.Parse(Console.ReadLine());
                
                }

            }
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int j = 0; j < numero.GetLength(1); j++)
                {
                    Console.Write("[" + numero[i, j] + "]" + " ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
