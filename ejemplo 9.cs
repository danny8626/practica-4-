using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            do
            {
                Console.Write("Digite el numero: ");
                valor = int.Parse(Console.ReadLine());

                Tabla tabla = new Tabla();
                if(valor != -1)
                {
                    tabla.cargar(valor);
                    Console.WriteLine("--------------------------");

                }
                else
                {
                    Environment.Exit(1);
                }
            

            }
            while (valor != -1);

            Console.ReadKey();
        }
    }
}
