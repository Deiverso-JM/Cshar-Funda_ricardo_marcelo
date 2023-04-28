using System;

namespace EstruturasMultiples{
    class program{
        static void Main(String[] args){

            //PROBLEMA 21
            int mes;

            Console.WriteLine("Escriba el numero del mes");
            mes = int.Parse(Console.ReadLine());

            switch(mes){
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Ese mes no existe, solo son 12 meses");
                    break;
            }

            
            //PROBLEMA 22

            int dia;

            Console.WriteLine("Escriba el numero del dia de la semana");
            dia = int.Parse(Console.ReadLine());

            switch(dia){
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                case 4:
                    Console.WriteLine("Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Jueves");
                    break;
                case 6:
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Ese dia de la semana no existe");
                    break;
            }


            //PROBLEMA 23

            
            char operador;

            Console.WriteLine("Escriba el simbolo del operador");
            operador = char.Parse(Console.ReadLine());

            switch(operador){
                case '+':
                    Console.WriteLine("Suma");
                    break;
                case '-':
                    Console.WriteLine("Resta");
                    break;
                case '/':
                    Console.WriteLine("Division");
                    break;
                case '*':
                    Console.WriteLine("Multiplicacion");
                    break;
                default:
                    Console.WriteLine("ese operador no existe");
                    break;
            }

            //PROBLEMA 24

            char canal;

            Console.WriteLine("Escriba el numero del dia de la semana");
            canal = char.Parse(Console.ReadLine());

            switch(canal){
                default:
                    Console.WriteLine($"El canal es el numero {canal}");
                    break;
            }


            //PROBLEMA 25

            string sexo,tarjeta;
            float sueldo, sueldoDescuento;
                        
                        
            Console.WriteLine("Escriba su sueldo por favor por favor");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba su genero todo en minuscula por favor");
            sexo = Console.ReadLine();
            Console.WriteLine("Escriba su cargo de tarjeta todo en minuscula por favor");
            tarjeta = Console.ReadLine();

            switch(sexo){
                case "femenino":
                    if(tarjeta == "obrero"){
                        sueldoDescuento = (float) (sueldo * 0.10);
                        Console.WriteLine($"El monto de descuento para usted sera de {sueldoDescuento}");
                    }else{
                        if(tarjeta != "empleado"){
                            Console.WriteLine("Tarjeta no tiene un cargo valido");
                        }else{
                            sueldoDescuento = (float)(sueldo*0.15);
                            Console.WriteLine($"El monto de descuento para usted sera de {sueldoDescuento}");
                        }
                    }
                    break;
                case "masculino":

                    if(tarjeta == "obrero"){
                        sueldoDescuento = (float)(sueldo*0.15);
                        Console.WriteLine($"El monto de descuento para usted sera de {sueldoDescuento}");
                    }else{
                        if(tarjeta != "empleado"){
                            Console.WriteLine("Tarjeta no tiene un cargo valido");
                        }else{
                            sueldoDescuento = (float)(sueldo*0.20);
                            Console.WriteLine($"El monto de descuento para usted sera de {sueldoDescuento}");
                        }
                    }

                    break;
                

                default:
                    Console.WriteLine("Datos invalidos, vuelva a ejecutar el programa");
                    break;
            }

            
            //PROBLEMA 26   
            float peso, compra;

            Console.WriteLine("Escribe la el peso de tu compra de manzanas");
            peso = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Escriba el precio total de su compra");
            compra = float.Parse(Console.ReadLine());

            if(peso == 0 || peso <=2){
                Console.WriteLine($"La perona debera pagar {compra}");
            }else if(peso >= 2.05 || peso <=5){
                compra =  (float) (compra - (compra*0.10));
                Console.WriteLine($"La persona debera pagar {compra}");
            }else if(peso >= 5.05 || peso <= 10){
                compra =  (float) (compra - (compra*0.20));
                Console.WriteLine($"La persona debera pagar {compra}");
            }else if(peso>10){
                compra =  (float) (compra - (compra*0.30));
                Console.WriteLine($"La persona debera pagar {compra}");
            }

            //PROBLEMA 27

            int Codigo;

            Console.WriteLine("Escriba su codigo de estado");
            Codigo = int.Parse(Console.ReadLine());

            switch(Codigo){
                case 1:
                    Console.WriteLine("Su estado civil es: Casado");
                    break;
                case 2:
                    Console.WriteLine("Su estado civil es: Divorsiado");
                    break;
                case 3: 
                    Console.WriteLine("Su estado civil es: Viudo");
                    break;
                case 0:
                    Console.WriteLine("Su estado civil es: Soltero");
                    break;
                default:
                    Console.WriteLine("El codgio no es valido y no existe");
                    break;
            }

            
            //PROBLEMA 28
            string cargo;
            int tiempo;

            Console.WriteLine("Escribe tu cargo en minuscula todo");
            cargo = Console.ReadLine();
            Console.WriteLine("Escribe tu tiempo de servicio");
            tiempo = int.Parse(Console.ReadLine());

            switch(cargo){
                case "administrador":
                    if(tiempo == 0 && tiempo<=2){
                        Console.WriteLine("Su monto a recibir es: " + 2000 );
                    }else if(tiempo == 3 && tiempo<=5){
                        Console.WriteLine("Su monto a recibir es: " + 2500 );
                    }else if(tiempo == 6 && tiempo<=8){
                        Console.WriteLine("Su monto a recibir es: " + 3000 );
                    }else if(tiempo >8){
                        Console.WriteLine("Su monto a recibir es: " + 4000 );
                    }
                    break;
                case "contador":
                    if(tiempo == 0 && tiempo<=2){
                        Console.WriteLine("Su monto a recibir es: " + 1500 );
                    }else if(tiempo == 3 && tiempo<=5){
                        Console.WriteLine("Su monto a recibir es: " + 2000 );
                    }else if(tiempo == 6 && tiempo<=8){
                        Console.WriteLine("Su monto a recibir es: " + 2500 );
                    }else if(tiempo >8){
                        Console.WriteLine("Su monto a recibir es: " + 3500 );
                    }
                    break;
                
                case "empleado":
                    if(tiempo == 0 && tiempo<=2){
                        Console.WriteLine("Su monto a recibir es: " + 1000 );
                    }else if(tiempo == 3 && tiempo<=5){
                        Console.WriteLine("Su monto a recibir es: " + 1500 );
                    }else if(tiempo == 6 && tiempo<=8){
                        Console.WriteLine("Su monto a recibir es: " + 2000 );
                    }else if(tiempo >8){
                        Console.WriteLine("Su monto a recibir es: " + 1500 );
                    }
                    break;
            }


            //PROBLEMA 29
            string sexo;
            int edad;

            Console.WriteLine("Escribe tu genero en minuscula todo");
            sexo = Console.ReadLine();
            Console.WriteLine("Escribe tu edad");
            edad = int.Parse(Console.ReadLine());

            switch(cargo){
                case "masculino":
                    if(edad == 18 && edad<=35){
                        Console.WriteLine("Usted visitara la ciudad de arequipa"  );
                    }else if(edad == 36 && edad<=75){
                        Console.WriteLine("Usted visitara la ciudad de cuzco  ");
                    }else if(edad >75){
                        Console.WriteLine("Usted visitara la ciudad de iquitos " );
                    }
                    break;
                
                case "femenino":
                    if(edad == 18 && edad<=35){
                        Console.WriteLine("Usted visitara la ciudad de cuzco"  );
                    }else if(edad == 36 && edad<=75){
                        Console.WriteLine("Usted visitara la ciudad de iquitos  ");
                    }else if(edad >75){
                        Console.WriteLine("Usted visitara la ciudad de arequipa " );
                    }
                    break;
            }



            //PROBLEMA 30
            int dias,dia,año,mes,diasAño,faltantes;

            Console.WriteLine("Escribe el año");
            año = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el mes");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el dia");
            dia = int.Parse(Console.ReadLine());

            if(año % 4 == 0 && (!(año % 100 != 0) || (año % 400 != 0))){
                dias=366;
                switch(mes){
                    case 1:
                        diasAño = dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 2:
                        if(dia >29){
                            Console.WriteLine("Febrero no tiene mas de 29 dias en año bisiesto");
                            break;
                        }else{
                            diasAño=31+dia;
                            faltantes = dias- diasAño;
                            Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                            break;
                        }
                    case 3:
                        diasAño=60+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 4:
                        diasAño=91+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 5: 
                        diasAño=121+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 6:
                        diasAño=152+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 7:
                        diasAño=182+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 8:
                        diasAño=213+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 9:
                        diasAño=244+dia;
                        break;
                    case 10:
                        diasAño=274+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 11:
                        diasAño=305+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 12:
                        diasAño=335+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                }
            }else{
                dias=365;
                switch(mes){
                    case 1:
                        diasAño = dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 2:
                        if(dia >28){
                            Console.WriteLine("Febrero no tiene mas de 29 dias en año bisiesto");
                            break;
                        }else{
                            diasAño=31+dia;
                             faltantes = dias- diasAño;
                            Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                            break;
                        }
                    case 3:
                        diasAño=59+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 4:
                        diasAño=90+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 5: 
                        diasAño=120+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 6:
                        diasAño=151+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 7:
                        diasAño=181+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 8:
                        diasAño=212+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 9:
                        diasAño=243+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 10:
                        diasAño=273+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 11:
                        diasAño=304+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    case 12:
                        diasAño=334+dia;
                        faltantes = dias- diasAño;
                        Console.WriteLine($"Los dias faltante para que se acabaen el año son {faltantes}");
                        break;
                    default:
                        Console.WriteLine("Ese mes del año no existe");
                        break;
                }


            }  


            




        }
    }
}