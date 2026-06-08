/* Código para crear un Struct de alumno que entre sus valores agrupados
se encuentra un vector de calificaciones. Se solicita la cantidad de
alumnos a capturar y todos los alumnos tienen un vector de calificaciones
de 4 posiciones.*/

using System;

namespace GrupoAlumnos{
	struct Alumno{
		public string nombre;
		public int edad;
		public int grado;
		public float[] calificaciones;
	}
	
	class Program{
		static void Main(string[] args){
			Console.WriteLine("¿Cuántos alumnos deseas registrar?");
			int totalAlumnos = int.Parse(Console.ReadLine());
			
			Alumno[] grupo = new Alumno[totalAlumnos];
			
			for (int i=0; i<totalAlumnos; i++){
				Console.WriteLine($"\n Alumno {i+1}:");
				
				Console.Write("Nombre: ");
				grupo[i].nombre=Console.ReadLine();
				
				Console.Write("Edad: ");
				grupo[i].edad= int.Parse(Console.ReadLine());
				
				Console.Write("Grado: ");
				grupo[i].grado= int.Parse(Console.ReadLine());
				
				Console.WriteLine("- Captura de Calificaciones - ");
				
				grupo[i].calificaciones = new float[4];
				
				for(int j=0; j<4; j++){
					Console.WriteLine($"\n Calificación {j+1} de {grupo[i].nombre}:");
					grupo[i].calificaciones[j]= float.Parse(Console.ReadLine());
				}// fin de for de captura de calificaciones
			}// fin for captura de alumnos
			
			Console.Clear();
			Console.WriteLine("=== LISTA DE ALUMNOS ===");
			for(int i=0; i<totalAlumnos; i++){
				Console.Write($"\n {grupo[i].nombre}, {grupo[i].edad}, {grupo[i].grado}:-");
				for(int j=0; j<4; j++){
					Console.Write($"{grupo[i].calficaciones[j]}-");
				}// fin de for de impresion de calificaciones
				
				
			}// fin for impresión alumnos			
		}// fin main
	}// fin class Program
	
}// fin namespace