/*Código para crear un arreglo con tamaño
capturado por el usuario.*/

// Herramienta del sistema para manejar la consola
using System;

namespace ArregloDinamico
{
    class Program
    {
        // El punto de partida de la aplicación
        static void Main(string[] args)
        {
            // Pregunta al usuario el tamaño que tendrá la lista
            Console.WriteLine("¿Cuántos valores deseas guardar?");
            int size = int.Parse(Console.ReadLine());

            // Crea el arreglo de números enteros con las casillas exactas solicitadas
            int[] lista = new int[size];

            // Primer ciclo: Recorre el arreglo para llenar cada casilla con un número
            for (int i = 0; i < size; i++)
            {
                // Le pide el dato al usuario (mostrando un número amigable: 1, 2, 3...)
                Console.WriteLine($"Ingresa el valor {i+1}:");
                // Convierte la entrada de texto a entero y la guarda en la posición actual
                lista[i] = int.Parse(Console.ReadLine());
            }

            // Segundo ciclo: Recorre el arreglo de inicio a fin para mostrar lo que se guardó
            for (int i = 0; i < size; i++)
            {
                // Imprime en pantalla el número de posición y el valor real guardado ahí
                Console.WriteLine($"Posición {i+1}: {lista[i]}");
            }
            
        } // fin Main
    } // fin class Program
} // fin namespace
