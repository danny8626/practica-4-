using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Array
{
    class Ejercico1
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [4];
            int mediaritmetica = 0;

            for(int i = 0; i  < numeros.Length; i++)
            {
                Console.Write("Digite un numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
                mediaritmetica += numeros[i];
            }
            mediaritmetica = mediaritmetica / numeros.Length;

            for (int o =0; o < numeros.Length; o++)
            {
                Console.WriteLine("El numero introducido es: " + numeros[o]);
            }

            Console.WriteLine("La media aritmetica es: " + mediaritmetica);

            Console.ReadKey();
        }
    }
}
