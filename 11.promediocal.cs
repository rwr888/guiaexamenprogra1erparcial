/*Este código crea un arreglo de calificaciones de tamaño establecido
por el usuario. Una vez que todas las calificaciones están
capturadas se recorre el arreglo para sumar las calificaciones
y calcular el promedio.*/

// Importa las herramientas necesarias para la consola
using System;

namespace ControlCalificaciones
{
    class Program
    {
        // El punto de inicio del programa
        static void Main(string[] args)
        {
            // Pregunta al usuario cuántas notas se van a registrar
            Console.WriteLine("¿Cuántas calificaciones deseas guardar?");
            int size = int.Parse(Console.ReadLine());

            // Crea el arreglo con la cantidad exacta de casillas que el usuario pidió
            float[] calificaciones = new float[size];
            
            // Variable que usaremos primero para acumular la suma y luego para el promedio
            float promedio = 0;

            // Primer ciclo: Llenar el arreglo de calificaciones elemento por elemento
            for (int i = 0; i < size; i++)
            {
                // Pide la calificación al usuario (muestra "Calificación 1", "Calificación 2", etc.)
                Console.WriteLine($"Ingresa la calificación {i+1}:");
                calificaciones[i] = float.Parse(Console.ReadLine());
                
                // Va acumulando la suma de todas las notas en la variable promedio
                promedio += calificaciones[i];
            }

            // Segundo ciclo: Recorrer e imprimir en pantalla cada calificación guardada
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Calificación {i+1}: {calificaciones[i]}");
            }

            // Divide la suma total acumulada entre la cantidad de calificaciones
            promedio = promedio / size;
            
            // Muestra el resultado final del promedio en la consola
            Console.WriteLine($"El promedio de calificaciones es: {promedio}");
            
        } // fin Main
    } // fin class Program
} // fin namespace