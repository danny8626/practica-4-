using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {


            valores val;


            Console.Write("Digiete el nombre de la persona: ");
            string nombre =Console.ReadLine();
            Console.Write("Digiete la edad de la persona: ");
            int edad = int.Parse(Console.ReadLine());

            val = new valores(nombre,edad);


            val.cargar();


            Console.ReadKey();
        }
    }
}
