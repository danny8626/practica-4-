/*using System;

namespace Ejercicios_array_y_clases
{
    
    // 6- Un programa que permita guardar datos de "imágenes" (ficheros de ordenador que contengan fotografías o cualquier otro tipo 
    // de información gráfica). De cada imagen se debe guardar: nombre (texto), ancho en píxeles (por ejemplo 2000), alto en píxeles 
    // (por ejemplo, 3000), tamaño en Kb (por ejemplo 145,6). El programa debe ser capaz de almacenar hasta 700 imágenes (deberá avisar 
    // cuando su capacidad esté llena). Debe permitir las opciones: añadir una ficha nueva, ver todas las fichas 
    // (número y nombre de cada imagen), buscar la ficha que tenga un cierto nombre.
    
    class Program
    {
        struct datosimagen
        {
            public string nombre;
            public int altura;
            public int ancho;
            public double tamaño;
        }
        
        static datosimagen[] aImagen = new datosimagen[700];
        static int Cont_ficha = 0, menu, i, contador = 0, contador2 = 0;         
        static string buscarxnombre;

        static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                Console.WriteLine("\n-----------------MENU DE OPCIONES-----------------\n");
                Console.WriteLine("1. - Agregar una ficha nueva.");
                Console.WriteLine("2. - Ver todas las fichas.");
                Console.WriteLine("3. - Buscar la ficha por nombre.");
                Console.WriteLine("4. - Salir del programa.");

                Console.Write("\nElija una opcion del menu: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Agregar_ficha();
                        break;

                    case 2:
                        Ver_fichas();
                        break;
                    
                    case 3:
                        Buscar_ficha();
                        break;

                    case 4:
                        Salir_program();
                        break;
                    
                    default: 
                        Console.WriteLine("\n" + "ERROR: LA OPCION ELEGIDA NO ES VALIDA.");
                        break;

                }
            } while (menu != 4);
        } 
    
        static void Agregar_ficha()
        {
            Console.Clear();
            Console.WriteLine("\n" + "-----------------Agregar una ficha nueva-----------------\n");

            if (Cont_ficha <= aImagen.Length)
            {
                    Console.Write("Cual el nombre de la imagen: ");
                    aImagen[contador].nombre = Console.ReadLine();

                    Console.Write("Cual es la altura de la imagen en pixeles: ");
                    aImagen[contador].altura = int.Parse(Console.ReadLine());

                    Console.Write("Cual es el ancho de la imagen en pixeles: ");
                    aImagen[contador].ancho = int.Parse(Console.ReadLine());

                    Console.Write("Cual es el tamaño de la imagen en KB: ");
                    aImagen[contador].tamaño = double.Parse(Console.ReadLine());

                    contador += 1;
                    Console.Write("Precione cualquier tecla..."); 
                    Console.ReadKey();
            } else
            {
                Console.WriteLine("\nERROR: REGISTRO DE FICHERO LLENO (700/700)");
            }
        }

        static void Ver_fichas()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Ver todas las fichas-----------------\n");
            contador2 = 0 ;
            
            for (i = 0; i < contador; i++)
            { 
                contador2 ++;
                Console.WriteLine("Fichero Numero " + contador2);
                Console.WriteLine("Nombre imagen: {0}| Anchura imagen: {1} px| Altura imagen: {2} px| Tamaño imagen: {3} KB\n",
                aImagen[i].nombre, aImagen[i].altura, aImagen[i].ancho, aImagen[i].tamaño);
            }

            Console.Write("Precione cualquier tecla..."); 
            Console.ReadKey();
        } 

        static void Buscar_ficha()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Buscar la ficha por nombre-----------------\n");

            Console.Write("Ingrese el nombre de la imagen que desea buscar: ");
            buscarxnombre = (Console.ReadLine());
            
            for (i = 0; i < contador; i++)
                if (aImagen[i].nombre == buscarxnombre)
                    Console.WriteLine("\n" + "Fichero Encontrado\n" + "Nombre imagen: {0}| Anchura imagen: {1} px| Altura imagen: {2} px| Tamaño imagen: {3} KB\n",
                    aImagen[i].nombre, aImagen[i].altura, aImagen[i].ancho, aImagen[i].tamaño);
                

            Console.Write("Precione cualquier tecla..."); 
            Console.ReadKey();
        }

        static void Salir_program()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Salir del programa-----------------\n");

            Console.Write("Precione cualquier tecla..."); 
            Console.ReadKey();
        }  
    }
}*/