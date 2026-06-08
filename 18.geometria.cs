/*Prueba de funciones. Con la longitud de un lado del triángulo se 
calcula la altura y después la base. Con la misma longitud capturada
se calcula el área de un cuadrado. Con la misma longitud se calcula 
el apotema del pentágono para posteriormente capturar el área. Todas
las funciones se mandan llamar desde Main y se despliega el resultado
directo a consola.*/

// Importa el espacio de nombres del sistema para funciones básicas (como Console)
using System;

// Define el espacio de nombres para organizar el código del proyecto
namespace Geometria
{
    // Clase principal que contiene la lógica del programa
    class Program
    {
        // Método principal: Punto de entrada donde inicia la ejecución del programa
        static void Main(string[] args)
        {
            // Muestra un mensaje en consola pidiendo el dato al usuario
            Console.WriteLine("Inserta la longitud del lado");
            
            // Lee el texto introducido por el usuario y lo convierte a un número de punto flotante (float)
            float lado = float.Parse(Console.ReadLine());
            
            // Imprime un mensaje indicando que se mostrará el área del triángulo equilátero
            Console.WriteLine($"El área del triangulo de lado {lado} es:");
            // Llama a la función CalcularAreaTriangulo e imprime el resultado devuelto
            Console.WriteLine(CalcularAreaTriangulo(lado));
            
            // Imprime un mensaje indicando que se mostrará el área del cuadrado
            Console.WriteLine($"El área del cuadrado de lado {lado} es:");
            // Llama a la función CalcularAreaCuadrado e imprime el resultado devuelto
            Console.WriteLine(CalcularAreaCuadrado(lado));
            
            // Imprime un mensaje indicando que se mostrará el área del pentágono regular
            Console.WriteLine($"El área del pentágono de lado {lado} es:");
            // Llama a la función CalcularAreaPentagono e imprime el resultado devuelto
            Console.WriteLine(CalcularAreaPentagono(lado));
        } // fin Main
        
        // Función para calcular el área de un triángulo equilátero usando la longitud de su lado
        static float CalcularAreaTriangulo(float baseT)
        {
            // Calcula la altura: (lado * raíz_cuadrada(3)) / 2
            // Multiplica la altura por la base y lo divide entre 2 para obtener el área total
            // Se usa (float) para convertir el resultado de double a float
            return (float)(((baseT * Math.Sqrt(3)) / 2) * baseT / 2);
        } // fin función Area Triángulo
        
        // Función para calcular el área de un cuadrado (lado * lado)
        static float CalcularAreaCuadrado(float ladoC)
        {
            // Multiplica el lado por sí mismo y regresa el resultado
            return ladoC * ladoC;
        }
        
        // Función para calcular el área de un pentágono regular basado en su lado
        static float CalcularAreaPentagono(float ladoP)
        {
            // Calcula el apotema: lado / (2 * tan(36°)). Se convierten los 36 grados a radianes.
            float apotema = (float)(ladoP / (2 * Math.Tan(36 * Math.PI / 180)));
            
            // Calcula el perímetro sumando los 5 lados del pentágono
            float perimetro = 5 * ladoP;
            
            // Calcula y regresa el área: (perímetro * apotema) / 2
            return perimetro * apotema / 2;
        }
    } // fin class program
} // fin namespace