/*Este código solicita al usuario un promedio y*
valida que contenga un valor entre 0 y 100*/

Console.WriteLine("Ingresa el nombre del alumno.");
string nombre = Console.ReadLine();

Console.WriteLine("Ingresa el promedio del alumno (de 0 a 100)");
int promedio = int.Parse(Console.ReadLine());//captura el valor ingresado por el usuario y lo convierte a un entero para almacenarlo en la variable "promedio"

// Validar rango de promedio
if(promedio<0 || promedio > 100){//si el promedio es menor a 0 o mayor a 100, se muestra un mensaje de error y se termina la ejecución del programa
	Console.WriteLine("Promedio no válido. Debe ser entre 0 y 100.");
	return;
}

Console.WriteLine($"Alumno: {nombre}");//muestra el nombre del alumno ingresado por el usuario
Console.WriteLine($"Promedio: {promedio}");//muestra el promedio del alumno ingresado por el usuario

// Determinar si el alumno tiene beca
if(promedio>=90){//si es mayor o igual a 90 se obtiene beca
	Console.WriteLine("Resultado: el alumno obtuvo la beca");
}
else{//si el promedio es menor a 90, no se obtiene beca
	Console.WriteLine("Resultado: el alumno no obtiene la beca :(");
}
Console.WriteLine("Fin del Proceso");//indica que el proceso ha terminado