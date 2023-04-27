using System;
class pronblema6 {
    static void Main(string[] args){
    
        //Condicionales

        //Problema 11

        int edad;
    
        Console.WriteLine("Escribe tu edad");
        edad = int.Parse(Console.ReadLine());
        if(edad >= 18){
            Console.WriteLine("Si es mayor de edad");
        }else{
            Console.WriteLine("No es mayor de edad");
        };


        //Problema 12

        int numner,num1,num2;

        Console.WriteLine("Escribe el numero 1");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escribe el numero 2");
        num2 = int.Parse(Console.ReadLine());

        if(num1 == num2){
            Console.WriteLine("Los numeros son iguales, no hay menor");
        }else{
            if(num1 > num2){
                numner = num2;
                Console.WriteLine("El numero menor es"+ numner);
            }else{
                numner = num1;
                Console.WriteLine("El numero menor es"+ numner);
            }
        }

        //Problema 13

        Console.WriteLine("Escribe el numero 1");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escribe el numero 2");
        num2 = int.Parse(Console.ReadLine());

        if(num1 == num2){
            Console.WriteLine("Los numeros son iguales");
        }else{
            Console.WriteLine("Los numeros son diferentes");
        }

        //Problema 14 
            
        Console.WriteLine("Escriba un numero");
        num1 = int.Parse(Console.ReadLine());
        int resul;
        if(num1 >0 && num1>1){
            resul=num1*2;
            Console.WriteLine("EL numero es positivo su valor es: " + resul);
        }else{
            resul=num1*3;
            Console.WriteLine("EL numero es negativo su valor es: " + resul);
        }

        if(num1 == 0 || num1 == 1){
            resul= 0; //SE INDICA EN EL LIBRO QUE CERO SI ES NEUTRO, NO SE DICE QUE SE HACE OPERACION
            Console.WriteLine("EL numero es neutro su valor es: " + resul);    
        }
        
        //Problema 15
        int num3,num1,num2;
		

        Console.WriteLine("Escribe el numero 1");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escribe el numero 2");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escribe el numero 3");
        num3= int.Parse(Console.ReadLine());

        if(num1 > num2 && num1 >num3){
            if(num2 > num3){
                Console.WriteLine("Forma decendente");
                Console.WriteLine(num1+ " " + num2 + " " + num3+ " ");
                Console.WriteLine("Forma acendente");
                Console.WriteLine(num3+ " " + num2 + " " + num1+ " ");
            }else{
                Console.WriteLine("Forma decendente");
                Console.WriteLine(num1+ " " + num3 + " " + num2+ " ");
                Console.WriteLine("Forma acendente");
                Console.WriteLine(num2+ " " + num3 + " " + num1+ " ");

            }
        }else{

            if(num2 > num3){
                Console.WriteLine("Forma acendente");
                Console.WriteLine(num1+ " " + num3 + "" + num2+ " ");
                Console.WriteLine("Forma decendente");
                Console.WriteLine(num2+ " " + num3 + "" + num1+ " ");
            }else{
                Console.WriteLine("Forma acendente");
                Console.WriteLine(num1+ " " + num2 + "" + num3+ " ");
                Console.WriteLine("Forma decendente");
                Console.WriteLine(num3+ " " + num2 + "" + num1+ " ");
            }
        }

        //Problema 16
        float nota1,nota2,nota3,nota4, promedio;

        Console.WriteLine("Escribe el numero 1");
        nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Escribe el numero 2");
        nota2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Escribe el numero 3");
        nota3= float.Parse(Console.ReadLine());
		Console.WriteLine("Escribe el numero 4");
        nota4= float.Parse(Console.ReadLine());
		
		
		
        if(nota1 < nota2 && nota1 < nota3 && nota1 <nota4){
            promedio=(nota4+nota2+nota3)/3;
            Console.WriteLine("El promedio es: " + promedio );
        }else{
            if(nota1 == nota2 || nota1 == nota3 ||  nota1 == nota4){
                Console.WriteLine("Hay notas iguales, no se puede sacar el mejor de 3 para promedio" );
            }else{
				
				if (nota2 == nota1 || nota2 == nota3 ||  nota2 == nota4){
					Console.WriteLine("Hay notas iguales, no se puede sacar el mejor de 3 para promedio" );
				}else{
					
					if(nota3 == nota1 || nota3 == nota2 ||  nota3 == nota4){
						Console.WriteLine("Hay notas iguales, no se puede sacar el mejor de 3 para promedio" );
					}else{
						
						if(nota2 < nota1 && nota2 < nota3 && nota2 <nota4){
                			promedio=(nota4+nota1+nota3)/3;
                			Console.WriteLine("El promedio es: " + promedio );
						}
			
            			if(nota3 < nota2 && nota3 < nota1 && nota3 <nota4){
                			promedio=(nota4+nota2+nota1)/3;
                			Console.WriteLine("El promedio es: " + promedio );
						}
						
            			if(nota4 < nota2 && nota4 < nota1 && nota4 <nota3){
                			promedio=(nota1+nota2+nota3)/3;
                			Console.WriteLine("El promedio es: " + promedio );
						}
					
					
					}
					

				
				
				}
					
			
			}

        }

        //Problema 17
        float saldAnterior,operacion, saldoNuevo;
        string opcion;

        Console.WriteLine("Buenas tardes, escribe el saldo anterior");
        saldAnterior = float.Parse(Console.ReadLine());
        Console.WriteLine("¿Que operacion desea hacer?");
        Console.WriteLine("1. Deposito(d)\n 2. Retiro (r)");
        opcion = Console.ReadLine();


        if(opcion == 'd'){
            Console.WriteLine("¿De cuanto es el monto de deposito?");
            operacion = float.Parse(Console.ReadLine());
            saldoNuevo = saldAnterior + operacion;
            Console.WriteLine("Su nuevo saldo es de : " + saldoNuevo);
        }else{
            if(opcion == 'r'){
                Console.WriteLine("¿De cuanto es el monto de retiro?");
                operacion = float.Parse(Console.ReadLine());
                if(operacion > saldAnterior){
                    Console.WriteLine("Cantidad excedida del saldo actual");
                    Console.WriteLine("No se puede hacer operacion");
                }else{
                    saldoNuevo = saldAnterior - operacion;
                    Console.WriteLine("Su nuevo saldo es de : " + saldoNuevo);
                }
            }else{
                Console.WriteLine("Opcion invalida");
            }
        }
        
        //Problema 18

            int a1,b1;
            Console.WriteLine("Buenas tardes, escribe el saldo anterior");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Buenas tardes, escribe el saldo anterior");
            b1 = int.Parse(Console.ReadLine());

            if(a1 == b1){
                Console.WriteLine("A es igual a b");
            }else{
                if(a1 > b1){
                    Console.WriteLine("A es mayor con respecto a b");

                }else{
                    Console.WriteLine("b es mayor con respecto a A");
                }
            }




        
        //Problema 19

        float lado1, lado2,lado3;
        Console.WriteLine("Buenas tardes, escribe el saldo anterior");
        lado1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Buenas tardes, escribe el saldo anterior");
        lado2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Buenas tardes, escribe el saldo anterior");
        lado3 = int.Parse(Console.ReadLine());


        if((lado1+lado2) > lado3 && (lado1-lado1) < lado3 ){
            Console.WriteLine("Si es un triangulo");
        }else{
            Console.WriteLine("No es un tringulo");

        }




    //Problema 20
    float lado1, lado2,lado3;
    Console.WriteLine("Escribe lado 1");
    lado1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Escribe lado 2");
    lado2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Escribe lado 3");
    lado3 = int.Parse(Console.ReadLine());  

    if(lado1 == lado2 && lado1 == lado3){
        Console.WriteLine("triangulo equilatero");
    }
    else{
        if(lado2 ==  lado3 || lado2 == lado1 || lado3 == lado1){
            Console.WriteLine("triangulo isosceles");
        }else{
            Console.WriteLine("triangulo escaleno");    
            }
        }
    }
}