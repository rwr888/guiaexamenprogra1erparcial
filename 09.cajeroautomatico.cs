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
            // Configuración de las variables iniciales de la cuenta
            int pinCorrecto = 1234;
            int saldo = 1500;
            
            // Solicita y captura el PIN de seguridad del usuario
            Console.WriteLine("Ingresa tu PIN.");
            int pinIngresado = int.Parse(Console.ReadLine());
            
            // VALIDACIÓN INICIAL: Si el PIN está mal, saca al usuario inmediatamente
            if(pinIngresado != pinCorrecto){
                Console.WriteLine("PIN incorrecto. Acceso denegado.");
                return; // Corta la ejecución del método Main por completo
            }// fin if
            
            // Variable que guardará la opción seleccionada en el menú
            int opcion;
            
            // Bucle principal: Despliega el menú al menos una vez y se repite hasta elegir "Salir"
            do{
                Console.WriteLine("\n ====== CAJERO AUTOMÁTICO ======");
                Console.WriteLine("1. Consultar Saldo.");
                Console.WriteLine("2. Depositar Dinero.");
                Console.WriteLine("3. Retirar Dinero.");
                Console.WriteLine("4. Salir.");
                Console.Write("Elige una opción: ");
                
                opcion = int.Parse(Console.ReadLine());
                
                // Evalúa la opción seleccionada por el usuario
                switch(opcion){
                    case 1:
                        // Opción 1: Muestra el saldo actual usando interpolación de cadenas
                        Console.WriteLine($"Tu saldo es: ${saldo}");
                        break; // Sale del switch para volver a evaluar la condición del ciclo
                        
                    case 2:
                        // Opción 2: Pide cantidad a depositar y la suma al saldo existente
                        Console.WriteLine("¿Cuánto deseas depositar?");
                        int deposito = int.Parse(Console.ReadLine());
                        saldo += deposito; // Equivalente a: saldo = saldo + deposito
                        Console.WriteLine($"Depósito exitoso de {deposito}. Nuevo saldo: ${saldo}");
                        break;
                        
                    case 3: 
                        // Opción 3: Pide cantidad a retirar. RECUERDA: Agregar "Console." antes de ReadLine()
                        Console.WriteLine("¿Cuánto deseas retirar?");
                        int retiro = int.Parse(ReadLine());
                        
                        // VALIDACIÓN: Revisa si el usuario tiene fondos suficientes para el retiro
                        if(retiro <= saldo){
                            saldo -= retiro; // Resta el dinero retirado del saldo: saldo = saldo - retiro
                            Console.WriteLine($"Retiro exitoso por ${retiro}. Nuevo Saldo: ${saldo}");
                        }
                        else{
                            // Mensaje de advertencia si intenta retirar más de lo que tiene
                            Console.WriteLine("Nel, mijo. Saldo insuficiente :(");
                        }
                        break;
                        
                    case 4: 
                        // Opción 4: Mensaje de despedida
                        Console.WriteLine("Gracias por su visita :)");
                        break;
                    
                    default:
                        // Si el usuario teclea un número que no sea del 1 al 4
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                
            }while (opcion!=4);// fin do while (Se repite MIENTRAS la opción NO sea 4)
           
        }// fin Main
    }// fin class
    
}//fin namespace
