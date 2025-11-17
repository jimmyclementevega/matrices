
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        //creamos metodos
         public static void ingresaelem(int[,] matriz,int fi,int col)
        {
            Console.WriteLine("ingresa los elementos");
            for (int i = 0; i < fi; i++)
            {
                for (int j = 0; j < col; j++)
                {

                    Console.Write("matriz [" + i + "][" + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        // metodo para mostrar la matriz
        public static void mostrar(int[,] matriz,int fi,int col)
        {
            Console.WriteLine("\nmostrando la matriz: ");
            for (int i = 0; i < fi; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
            }

        }
        // buscar elementos
        public static void buscar(int[,] matriz, int fi, int col,int num)
        {
            bool buscado = false;

            for (int i = 0; i < fi; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matriz[i,j] == num )
                    {
                        Console.Write("el numero si se encontro");
                        buscado = true;
                        
                    } 
                }
            }
            if (!buscado)
                Console.WriteLine("el numero no se encotro en el la matriz");
        }
        static void Main(string[] args)
        {
            int fila = 3, valor;
            int columnas = 3;
            int[,] matriz = new int[fila, columnas];
            //invocamos al metod a ingresar 
            ingresaelem(matriz, fila, columnas);
            //mostramos la matriz
            mostrar(matriz, fila, columnas);
            //buscar el valor
            Console.WriteLine("\ningrese el valor a buscar");
            valor = int.Parse(Console.ReadLine());
            buscar(matriz, fila,columnas,valor);

        }
    }
}
