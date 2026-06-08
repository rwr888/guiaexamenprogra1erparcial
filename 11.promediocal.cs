/*Este código crea un arreglo de calificaciones de tamaño establecido
por el usuario. Una vez que todas las calificaciones están
capturadas se recorre el arreglo para sumar las calificaciones
y calcular el promedio.*/

Console.WriteLine("¿Cuántas calificaciones deseas guardar?");
int size = int.Parse(Console.ReadLine());

// Crear arreglo de calificaciones con el tamaño capturado
float[] calificaciones = new float[size];
float promedio=0;

// Llenar arreglo de calificaciones elemento por elemento
for(int i=0; i<size; i++){
	Console.WriteLine($"Ingresa la calificación {i+1}:");
	calificaciones[i]= float.Parse(Console.ReadLine());
	promedio+= calificaciones[i];
}

// Imprimir arreglo de calificaciones, elemento por elemento
for(int i=0; i<size; i++){
	Console.WriteLine($"Calificación {i+1}: {calificaciones[i]}");
}

promedio= promedio/size;
Console.WriteLine($"El promedio de calificaciones es: {promedio}");