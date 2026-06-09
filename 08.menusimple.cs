/*Este código muestra un menú de 3 opciones
Se repite mientras la opción elegida sea 
distinta de 3*/

// Trae las herramientas esenciales del sistema (necesario para Console y DateTime)
using System;

namespace MenuBasico
{
    class Program
    {
        // El punto de partida de la aplicación
        static void Main(string[] args)
        {
            // Variable para almacenar el número de opción que digite el usuario
            int option;

            // Bucle que ejecuta el menú al menos una vez y se repite según la condición
            do
            {
                // Muestra las opciones del menú en la pantalla
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Mostrar hora");
                Console.WriteLine("3. Salir");
                
                // Lee la respuesta del usuario y la convierte a número entero
                option = int.Parse(Console.ReadLine());
                
                // Evalúa las opciones con condicionales
                if (option == 1)
                {
                    // Si el usuario tecleó 1, muestra un saludo sencillo
                    Console.WriteLine("Hola!");
                }
                else if (option == 2)
                {
                    // Si el usuario tecleó 2, imprime la fecha y hora actuales del sistema
                    Console.WriteLine(DateTime.Now);
                }
                
                // Nota: Si eligen la opción 3, no entra a ningún "if" y va directo al cierre del ciclo
                
            } while (option != 3); // El ciclo se repite MIENTRAS la opción NO sea igual a 3
            
        } // fin Main
    } // fin class Program
} // fin namespace
