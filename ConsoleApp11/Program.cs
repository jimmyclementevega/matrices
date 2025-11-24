using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            char[] arreglo;
            Console.WriteLine("ingrese una palabra");
            palabra = Console.ReadLine();
            //convertir la palabra string a un arreglo tipo char
            arreglo = palabra.ToCharArray();
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("[" + arreglo[i] + "]" + " ");
            }
            Console.ReadKey();

        }
    }
}
