/*Código para mostrar en consola un "Hola, mundo" y otras funciones simples
solicitar imprimir números. Las funciones que se definan deben estar en el
    mismo nivel de la función Main para funcionar.*/

// Trae las herramientas básicas de C# para no escribir código de más
using System;

// El contenedor general para organizar este proyecto
namespace HolaMundoFunc
{
    // La clase principal donde vive todo nuestro código
    class Program
    {
        // El bloque principal. Aquí arranca el programa y se ejecuta todo en orden
        static void Main(string[] args)
        {
            // Llama a la función que se encarga de saludar en pantalla
            ImprimirHolaMundo();
            
            // Pide el primer número al usuario y lo guarda en la variable "miNumero"
            float miNumero = ImprimirNumero();
            
            // Vuelve a pedir un número y lo guarda en la variable "miNumerote"
            float miNumerote = ImprimirNumero();
            
            // Le envía los dos números a la función de sumar y guarda el total aquí
            float resultadoSuma = SumarNumeros(miNumero, miNumerote);
            
        } // fin Main
        
        // Función sencilla que solo sirve para mostrar un saludo en la consola
        static void ImprimirHolaMundo()
        {
            Console.WriteLine("Hola, Mundo desde una función :v");
        }
        
        // Función para pedir un número, mostrarlo en pantalla y regresarlo al Main
        static float ImprimirNumero()
        {
            // Le avisa al usuario qué tipo de dato debe ingresar
            Console.WriteLine("Inserta un número flotante");
            
            // Lee lo que escribió el usuario y lo convierte a número decimal (float)
            float num1 = float.Parse(Console.ReadLine());
            
            // Muestra en la pantalla el número que se acaba de registrar
            Console.WriteLine($"Número capturado: {num1}");
            
            // Regresa el número para que quien llamó a la función lo pueda utilizar
            return num1;
        }
        
        // Función que recibe dos números, los suma y te devuelve el resultado
        static float SumarNumeros(float num1, float num2)
        {
            // Realiza la suma matemática básica
            float resultado = num1 + num2;
            
            // Devuelve el resultado final de la operación
            return resultado;
        }
    } // fin class Program
    
} //fin namespace