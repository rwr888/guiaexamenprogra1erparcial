/*Este código simula un cajero automático.
El pin se guarda en una variable.
El saldo inicial se guarda en una variable

Si el PIN capturado por el usuario no coincide con
el PIN almacenado, el programa termina.

Se puede Consultar, Depositar y Retirar. 
*/

using System;
namespace CajeroAutomatico{
	
	class Program{
		static void Main(string[] args){
			int pinCorrecto = 1234;
			int saldo = 1500;
			
			Console.WriteLine("Ingresa tu PIN.");
			int pinIngresado = int.Parse(Console.ReadLine());
			
			if(pinIngresado != pinCorrecto){
				Console.WriteLine("PIN incorrecto. Acceso denegado.");
				return;
			}// fin if
			
			int opcion;
			// Despliegue del menú principal.
			do{
				Console.WriteLine("\n ====== CAJERO AUTOMÁTICO ======");
				Console.WriteLine("1. Consultar Saldo.");
				Console.WriteLine("2. Depositar Dinero.");
				Console.WriteLine("3. Retirar Dinero.");
				Console.WriteLine("4. Salir.");
				Console.Write("Elige una opción");
				
				opcion = int.Parse(Console.ReadLine());
				
				switch(opcion){
					case 1:
						Console.WriteLine($"Tu saldo es: ${saldo}");
						break;
						
					case 2:
						Console.WriteLine("¿Cuánto deseas depositar?");
						int deposito = int.Parse(Console.ReadLine());
						saldo += deposito;
						Console.WriteLine($"Depósito exitoso de {deposito}. Nuevo saldo: ${saldo}");
						break;
						
					case 3: 
						Console.WriteLine("¿Cuánto deseas retirar?");
						int retiro = int.Parse(ReadLine());
						
						if(retiro <= saldo){
							saldo -= retiro;
							Console.WriteLine($"Retiro exitoso por ${retiro}. Nuevo Saldo: ${saldo}");
						}
						else{
							Console.WriteLine("Nel, mijo. Saldo insuficiente :(");
						}
						break;
						
					case 4: 
						Console.WriteLine("Gracias por su visita :)");
						break;
					
					default:
						Console.WriteLine("Opción no válida.");
						break;
				
			}while (opcion!=4);// fin do while
           
		}// fin Main
	}// fin class
	
}//fin namespace