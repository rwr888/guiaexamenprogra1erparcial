/*Definición de datos compuestos que agrupan distintos tipos de datos.
Se requiere la estructura formal base de un programa en C# para poder
definir structs.*/

using System;

namespace EjemploStruct{
	struct Alumno{
		public string nombre;
		public int edad;
		public string carrera;
	}
	
	class Program{
		static void Main(string[] args){
			Alumno alumno1;
			
			Console.WriteLine("Ingresa el nombre del alumno.");
			alumno1.nombre=Console.ReadLine();
			
			Console.WriteLine("Ingresa la edad del alumno:");
			alumno1.edad = int.Parse(ReadLine());
			
			Console.WriteLine("Ingresa la carrera del alumno:");
			alumno1.carrera=Console.ReadLine();
			
			Console.WriteLine($" Alumno Registrado: {alumno1.nombre}, {alumno1.edad} años, {alumno1.carrera}");
           
		}
	}
	
}