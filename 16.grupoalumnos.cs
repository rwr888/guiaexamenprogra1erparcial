/* Código para crear un Struct de alumno que entre sus valores agrupados
se encuentra un vector de calificaciones. Se solicita la cantidad de
alumnos a capturar y todos los alumnos tienen un vector de calificaciones
de 4 posiciones.*/

using System;

namespace GrupoAlumnos{
    // Define la estructura para agrupar los datos de un solo alumno
    struct Alumno{
        public string nombre;
        public int edad;
        public int grado;
        public float[] calificaciones; // Vector que guardará las 4 notas del alumno
    }
    
    class Program{
        static void Main(string[] args){
            // Pregunta al usuario cuántos alumnos va a registrar en total
            Console.WriteLine("¿Cuántos alumnos deseas registrar?");
            int totalAlumnos = int.Parse(Console.ReadLine());
            
            // Crea el arreglo ("el grupo") con el tamaño que el usuario pidió
            Alumno[] grupo = new Alumno[totalAlumnos];
            
            // Ciclo principal para recorrer y llenar los datos de cada alumno
            for (int i=0; i<totalAlumnos; i++){
                Console.WriteLine($"\n Alumno {i+1}:");
                
                // Guarda el nombre directamente como texto
                Console.Write("Nombre: ");
                grupo[i].nombre=Console.ReadLine();
                
                // Pide la edad y la convierte a número entero
                Console.Write("Edad: ");
                grupo[i].edad= int.Parse(Console.ReadLine());
                
                // Pide el grado y lo convierte a número entero
                Console.Write("Grado: ");
                grupo[i].grado= int.Parse(Console.ReadLine());
                
                Console.WriteLine("- Captura de Calificaciones - ");
                
                // APARTADO CLAVE: Crea el espacio en memoria para las 4 calificaciones de ESTE alumno
                grupo[i].calificaciones = new float[4];
                
                // Ciclo secundario para pedir las 4 calificaciones una por una
                for(int j=0; j<4; j++){
                    Console.WriteLine($"\n Calificación {j+1} de {grupo[i].nombre}:");
                    grupo[i].calificaciones[j]= float.Parse(Console.ReadLine());
                }// fin de for de captura de calificaciones
            }// fin for captura de alumnos
            
            // Limpia la pantalla de la consola para mostrar los resultados limpios
            Console.Clear();
            Console.WriteLine("=== LISTA DE ALUMNOS ===");
            
            // Ciclo para mostrar en pantalla los datos de cada alumno registrado
            for(int i=0; i<totalAlumnos; i++){
                // Imprime los datos básicos separados por comas
                Console.Write($"\n {grupo[i].nombre}, {grupo[i].edad}, {grupo[i].grado}:-");
                
                // Ciclo para imprimir las 4 calificaciones del alumno actual en la misma línea
                for(int j=0; j<4; j++){
                    // RECUERDA: Aquí dice "calficaciones", cámbialo a "calificaciones" para que compile
                    Console.Write($"{grupo[i].calificaciones[j]}-");
                }// fin de for de impresion de calificaciones
                
            }// fin for impresión alumnos           
        }// fin main
    }// fin class Program
    
}// fin namespace