/*Prueba de funciones. Con la longitud de un lado del triángulo se 
calcula la altura y después la base. Con la misma longitud capturada
se calcula el área de un cuadrado. Con la misma longitud se calcula 
el apotema del pentágono para posteriormente capturar el área. Todas
las funciones se mandan llamar desde Main y se despliega el resultado
directo a consola.*/

using System;

namespace Geometria{
	
	class Program{
		static void Main(string[] args){
			Console.WriteLine("Inserta la longitud del lado");
			float lado= float.Parse(Console.ReadLine());
			
			Console.WriteLine($"El área del triangulo de lado {lado} es:");
			Console.WriteLine(CalcularAreaTriangulo(lado));
			
			Console.WriteLine($"El área del cuadrado de lado {lado} es:");
			Console.WriteLine(CalcularAreaCuadrado(lado));
			
			Console.WriteLine($"El área del pentágono de lado {lado} es:");
			Console.WriteLine(CalcularAreaPentagono(lado));
		}// fin Main
		
		static float CalcularAreaTriangulo(float baseT){
			/*float altura = (baseT*Math.Sqrt(3))/2;
			float areaT = baseT*altura/2;
			return areaT;*/
			return ((baseT*Math.Sqrt(3))/2)*baseT/2;
		}// fin función Area Triángulo
		
		static float CalcularAreaCuadrado(float ladoC){
			return ladoC*ladoC;
		}
		
		static float CalcularAreaPentagono(float ladoP){
			float apotema= ladoP/(2*Math.Tan(36));
			float perimetro = 5*ladoP;
			return perimetro*apotema/2;
			//return (5*ladoP)*(ladoP/(2*Math.Tan(36)))/2;
		}
	}// fin class program
}// fin namespace