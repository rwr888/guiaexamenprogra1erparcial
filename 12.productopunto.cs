/* Deste código realiza la operación de producto punto
entre dos vectores representador por los arreglos A y B
que estan definidos desde el inicio de la rutina.*/

int[] A= {2,4,6};
int[] B= {1,3,5};

int productoPunto=0;

for(int i=0;i<3;i++){
	productoPunto+=A[i]*B[i];
}

Console.WriteLine("Vector A: ");
for(int i=0;i<3;i++){
	Console.WriteLine(A[i]);
}

Console.WriteLine("Vector B: ");
for(int i=0;i<3;i++){
	Console.WriteLine(B[i]);
}

Console.WriteLine($"Producto Punto: {productoPunto}");