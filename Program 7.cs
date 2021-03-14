/*using System;

namespace Ejercicios_array_y_clases
{
    // 7- Un programa que te pida tu nombre y lo muestre en pantalla separando cada letra de la siguiente con un espacio. 
    // Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla "J u a n".
    
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Clear();
            Console.Write("Escribe tu nombre: ");
            nombre = Console.ReadLine();

            char[] separar_letra = nombre.ToCharArray();
            
            Console.WriteLine("\n" + "El nombre ({0}) separado en silabas es: ", nombre);
            foreach (char Silaba in separar_letra)
            {
                Console.Write(Silaba + " ");
            }
            
            Console.ReadKey();
        }
    }
}*/