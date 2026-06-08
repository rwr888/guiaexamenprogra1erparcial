/*Este código solicita al usuario un promedio y*
valida que contenga un valor entre 0 y 100*/

Console.WriteLine("Ingresa el nombre del alumno.");
string nombre = Console.ReadLine();

Console.WriteLine("Ingresa el promedio del alumno (de 0 a 100)");
int promedio = int.Parse(Console.ReadLine());

// Validar rango de promedio
if(promedio<0 || promedio > 100){
	Console.WriteLine("Promedio no válido. Debe ser entre 0 y 100.");
	return;
}

Console.WriteLine($"Alumno: {nombre}");
Console.WriteLine($"Promedio: {promedio}");

// Determinar si el alumno tiene beca
if(promedio>=90){
	Console.WriteLine("Resultado: el alumno obtuvo la beca");
}
else{
	Console.WriteLine("Resultado: el alumno no obtiene la beca :(");
}
Console.WriteLine("Fin del Proceso");