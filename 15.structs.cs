/*Definición de datos compuestos que agrupan distintos tipos de datos.
Se requiere la estructura formal base de un programa en C# para poder
definir structs.*/

using System;

namespace EjemploStruct{
    // Definición de la estructura "Alumno". Es la plantilla o molde base.
    struct Alumno{
        // Atributos públicos para que se puedan modificar desde fuera del struct
        public string nombre;
        public int edad;
        public string carrera;
    }
    
    class Program{
        static void Main(string[] args){
            // Se crea una variable llamada "alumno1" usando el molde de la estructura Alumno
            Alumno alumno1;
            
            // Pide el nombre en pantalla y lo asigna al atributo .nombre de alumno1
            Console.WriteLine("Ingresa el nombre del alumno.");
            alumno1.nombre=Console.ReadLine();
            
            // Pide la edad. RECUERDA: Aquí debes agregar "Console." antes de ReadLine() para que no marque error
            Console.WriteLine("Ingresa la edad del alumno:");
            alumno1.edad = int.Parse(Console.ReadLine());
            
            // Pide la carrera en pantalla y lo asigna al atributo .carrera de alumno1
            Console.WriteLine("Ingresa la carrera del alumno:");
            alumno1.carrera=Console.ReadLine();
            
            // Muestra en una sola línea de consola todos los datos agrupados que se capturaron
            Console.WriteLine($" Alumno Registrado: {alumno1.nombre}, {alumno1.edad} años, {alumno1.carrera}");
           
        }
    }
    
}