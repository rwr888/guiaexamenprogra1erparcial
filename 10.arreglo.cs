/*Código para crear un arreglo con tamaño
capturado por el usuario.*/

Console.WriteLine("¿Cuántos valores deseas guardar?");
int size = int.Parse(Console.ReadLine());

// Crear arreglo de enteros con el tamaño capturado
int[] lista = new int[size];

// Llenar arreglo de enteros elemento por elemento
for(int i=0; i<size; i++){
	Console.WriteLine($"Ingresa el valor {i+1}:");
	lista[i]= int.Parse(Console.ReadLine());
}

// Imprimir arreglo de enteros, elemento por elemento
for(int i=0; i<size; i++){
	Console.WriteLine($"Posición {i+1}: {lista[i]}");
}