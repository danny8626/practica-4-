using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[5];

            for (int i =0; i < numeros.Length; i ++)
            {
                Console.Write("Digite el numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
         
            Array.Reverse(numeros, 0, numeros.Length);

            Console.WriteLine("Numeros en orden inverso");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Numero inverso: " + numeros[i]);
            }
            Console.ReadKey();
        }
    }
}
