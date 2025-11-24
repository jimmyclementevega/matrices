using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            char[] arreglo;
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            arreglo = nombre.ToCharArray();
            Console.WriteLine("bienvenido :");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i]);
            }
            Console.ReadKey(); 
        }
    }
}
