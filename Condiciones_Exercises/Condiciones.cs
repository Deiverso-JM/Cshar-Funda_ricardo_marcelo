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
        int num3,aux;

        Console.WriteLine("Escribe el numero 1");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escribe el numero 2");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escribe el numero 3");
        num3= int.Parse(Console.ReadLine());

        if(num1 > num2 && num1 >num3){
            if(num2 > num3){
                Console.WriteLine("Forma acendente");
                Console.WriteLine(num1+ " " + num2 + " " + num3+ " ");
                Console.WriteLine("Forma decendente");
                Console.WriteLine(num3+ " " + num2 + " " + num1+ " ");
            }else{
                Console.WriteLine("Forma acendente");
                Console.WriteLine(num1+ " " + num3 + " " + num2+ " ");
                Console.WriteLine("Forma decendente");
                Console.WriteLine(num2+ " " + num3 + " " + num1+ " ");

            }
        }else{

            if(num2 > num3){
                Console.WriteLine("Forma decendente");
                Console.WriteLine(num1+ " " + num3 + "" + num2+ " ");
                Console.WriteLine("Forma acendente");
                Console.WriteLine(num1+ " " + num3 + "" + num2+ " ");
            }else{
                Console.WriteLine("Forma decendente");
                Console.WriteLine(num1+ " " + num2 + "" + num3+ " ");
                Console.WriteLine("Forma acendente");
                Console.WriteLine(num3+ " " + num2 + "" + num1+ " ");
            }
        }

        //Problema 16
        //Problema 17
        //Problema 18
        //Problema 19
        //Problema 20
        //Problema 21
        //Problema 22






    }
}