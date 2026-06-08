/*Este código muestra un menú de 3 opciones
Se repite mientras la opción elegida sea 
distinta de 3*/

int option;

do{
	Console.WriteLine("Elige una opción:");
	Console.WriteLine("1. Saludar");
	Console.WriteLine("2. Mostrar hora");
	Console.WriteLine("3. Salir");
	
	option=int.Parse(Console.ReadLine());
	
	if(option==1)
		Console.WriteLine("Hola!");
	else if(option ==2)
		Console.WriteLine(DateTime.Now);
	
}while(option!=3);