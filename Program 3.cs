/*using System;

namespace Ejercicios_array_y_clases
{
   // 3- Un programa que almacene en un array el número de días que tiene cada mes (supondremos que es un año no bisiesto), 
   // pida al usuario que le indique un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.
    
    class Program
    {
        static void Main(string[] args)
        {

            int[] dias = {0 ,31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            string [] mes = {"null", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            
            Console.Clear();
            
            for (int i = 1; i < mes.Length; i++)
            {
                Console.WriteLine(i + " = " + mes[i]);
            }
            
            // Pedir el numero al usuario y luego mostrarle los dias del mes.
            Console.WriteLine("\nIngrese el numero del mes que desea saber la cantidad de dias. Ejemplo: 1 = enero, 12 = diciembre.");
            Console.Write("\nEL NUMERO DEL MES ES: ");
            int Num_mes = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEl mes de " + mes[Num_mes] + " tienes " + dias[Num_mes] + " dias.\n");
            
        }
    }
}*/