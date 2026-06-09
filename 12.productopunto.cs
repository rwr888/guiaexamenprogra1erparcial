/* Deste código realiza la operación de producto punto
entre dos vectores representador por los arreglos A y B
que estan definidos desde el inicio de la rutina.*/

// Importa las herramientas esenciales de consola
using System;

namespace OperacionesVectores
{
    class Program
    {
        // Punto de entrada obligatorio del programa
        static void Main(string[] args)
        {
            // Define el primer vector A con 3 elementos (X=2, Y=4, Z=6)
            int[] A = { 2, 4, 6 };
            
            // Define el segundo vector B con 3 elementos (X=1, Y=3, Z=5)
            int[] B = { 1, 3, 5 };

            // Variable acumuladora para guardar el resultado final de la operación
            int productoPunto = 0;

            // Ciclo para calcular el producto punto recorriendo ambos vectores al mismo tiempo
            for (int i = 0; i < 3; i++)
            {
                // Multiplica los elementos de la misma posición y los va sumando al total
                productoPunto += A[i] * B[i];
            }

            // Muestra en consola los elementos del Vector A
            Console.WriteLine("Vector A: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(A[i]);
            }

            // Muestra en consola los elementos del Vector B
            Console.WriteLine("Vector B: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(B[i]);
            }

            // Imprime el resultado final escalar (un solo número) en la pantalla
            Console.WriteLine($"Producto Punto: {productoPunto}");
            
        } // fin Main
    } // fin class Program
} // fin namespace