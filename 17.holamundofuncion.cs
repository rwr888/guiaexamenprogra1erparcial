/*Código para mostrar en consola un "Hola, mundo" y otras funciones simples
solicitar imprimir números. Las funciones que se definan deben estar en el
	mismo nivel de la función Main para funcionar.*/

using System;

namespace HolaMundoFunc{
	
	
	class Program{
		static void Main(string[] args){
			ImprimirHolaMundo();
			
			float miNumero= ImprimirNumero();
			float miNumerote = ImprimirNumero();
			
			float resultadoSuma = SumarNumeros(miNumero,miNumerote);
           
		}// fin Main
		
		static void ImprimirHolaMundo(){
			Console.WriteLine("Hola, Mundo desde una función :v");
		}
		
		static float ImprimirNumero(){
			Console.WriteLine("Inserta un número flotante");
			float num1= float.Parse(Console.ReadLine());
			Console.WriteLine($"Número capturado: {num1}");
			
			return num1;
		}
		
		static float SumarNumeros(float num1, float num2){
			float resultado= num1 + num2;
			return resultado;
			
		}
	}// fin class Program
	
}//fin namespace