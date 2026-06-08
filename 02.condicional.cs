Console.WriteLine("Ingrese su edad:");//imprime en consola el mensaje para solicitar la edad al usuario
int edad = int.Parse(Console.ReadLine());//captura el valor ingresado por el usuario y lo convierte a un entero para almacenarlo en la variable "edad"

/* Para funcionar, el "if" debe contener una
condición que retorne un valor booleano (true, false)*/
if(edad>=18){//si la edad es mayor o igual a 18, se ejecuta el bloque de instrucciones dentro del "if"
	Console.WriteLine("Eres mayor de edad.");
}
else{//si la condición del "if" no se cumple, se ejecuta el bloque de instrucciones dentro del "else"
	Console.WriteLine("Eres menor de edad.");
	if(edad>=12){
		Console.WriteLine("Eres un adolescente.");
	}
	else{
		Console.WriteLine("Eres un infante.");
	}
}