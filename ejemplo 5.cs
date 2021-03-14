using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[100];
            int i = 0;

        

            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter))
            {

                Console.Write("Digite el nombre: ");
                 nombre[i] = Console.ReadLine();
             
              
            }

            Console.Write("sali ");

            Console.ReadKey();
        }
    }
}
