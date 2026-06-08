/*El código realiza el producto cruz entre dos vectores que,
siguiendo las fórmulas de álgebra lineal, genera un tercer
vector que almacena el resultado.*/

// Vectores predefinidos
int[] A = { 2, 3, 4 };
int[] B = { 5, 6, 7 };

// Vector resultado del producto cruz
int[] C = new int[3];

// Fórmulas del producto cruz
C[0] = A[1] * B[2] - A[2] * B[1];
C[1] = A[2] * B[0] - A[0] * B[2];
C[2] = A[0] * B[1] - A[1] * B[0];

Console.WriteLine("Producto Cruz: ");
for(int i=0; i<3; i++){
	
    Console.WriteLine($"C[{i+1}]:{C[i]}:");
}