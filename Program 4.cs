/*using System;

namespace Ejercicios_array_y_clases
{
    // 4- Un programa que pida al usuario 10 números y luego calcule y muestre cuál 
    // es el mayor de todos ellos.
    
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero_contador = 0;
            int[] aNumeros = new int[10];
            
            Console.WriteLine("\n");
            Console.Clear();

            for (int i = 0; i < aNumeros.Length; i++)
            {
                numero_contador = numero_contador + 1;
                Console.Write("Introduzca su numero {0}: ", numero_contador);
                aNumeros [i]= int.Parse(Console.ReadLine());
            }

            Array.Sort(aNumeros);
            Array.Reverse(aNumeros);

            Console.Write("\nEl Mayor de los numeros es: ");
            Console.WriteLine(aNumeros[0]);
        }
    }
}*/