/*using System;

namespace Ejercicios_array_y_clases
{
    // 8- Crear un programa que defina un array de 5 elementos de tipo float que representen las alturas de 5 personas.
    // Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.
    
    class Program
    {
        
        static float[] altura = {5.11f, 5.4f, 4.8f, 6.0f, 5.2f};
        static float suma = 0;
        static float promedio;
        static int alto = 0, bajo = 0;
        
        static void Main(string[] args)
        {
           Console.Clear();
           alt_promedio();
           alto_bajo();
        }

        static void alt_promedio()
        {

            for (int i = 0; i < altura.Length; i++)
            {
                suma += altura[i];
            }

            promedio = suma / 5;
            Console.WriteLine("El promedio de altura es: " + promedio + "f");
        }

        static void alto_bajo()
        {

            for (int i = 0; i < 5; i++)
            {
                if (altura[i] < promedio)
                {
                    alto++;
                }
                else
                {
                    if (altura[i] > promedio)
                    {
                        bajo++;
                    }
                }
            }

            Console.WriteLine("\n" + "Personas personas mayores al promedio: " + alto);
            Console.WriteLine("Personas personas menores al promedio: " + bajo);
            Console.ReadKey();
        }


    }
}*/