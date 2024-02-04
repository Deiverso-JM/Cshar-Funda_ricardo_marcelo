//Funciones - Ejercicio 71


namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el valor de un lado del cuadrado");
            float lado = float.Parse(Console.ReadLine());
            FoundAreaAndPerimetro(lado);
        }



        private static void FoundAreaAndPerimetro(float lado)
        {

            float area = (float) Math.Pow(lado, 2);
            float perimetro = lado * 4;

            Console.WriteLine($"El area del cuadrado es {area}");
            Console.WriteLine($"El perimetro del cuadrado es {perimetro}");
        }
    }
}




//--------------------------------------


//Funciones - Ejercicio 72


namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] notas = new decimal[3];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Escribe la nota {i}");
                notas[i] = decimal.Parse(Console.ReadLine()); 
            }


            decimal NotaPromedio = PromedioNotas(notas);

            Console.WriteLine($"El promedio de las dos notas mayores es: {NotaPromedio}");

        }


        private static decimal PromedioNotas(decimal[] notas)
        {
            Array.Sort(notas);

            decimal promedio = (notas[1] + notas[2] )/ 2;
            return promedio;



        }
    }
}

//--------------------------------------


//Funciones - Ejercicio 73


namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;

            Console.WriteLine("Escribe tu edad");
            edad = int.Parse(Console.ReadLine());

            EtapaVida(edad);
        }


        private static void EtapaVida(int edad)
        {
            string etapa = string.Empty;

            switch (edad)
            {
                case int n when n <=2:
                    etapa = "bebe";
                    break;
                case int n when n > 2 && n <= 5:
                    etapa = "Nino";
                    break;
                case int n when n > 5 && n <= 12:
                    etapa = "Puber";
                    break;
                case int n when n > 12 && n <= 18:
                    etapa = "Adolecente";
                    break;

                case int n when n > 19 && n <= 25:
                    etapa = "Joven";
                    break;
                case int n when n > 25 && n <= 60:
                    etapa = "Adulto";
                    break;
                case int n when n > 60:
                    etapa = "Anciano";
                break;
            }


            Console.WriteLine($"Tienes la edad {edad} y estas en la etapa de tu vida {etapa}");


        }
    }
}

//--------------------------------------

//Funciones - Ejercicio 74


namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;

            Console.WriteLine("Escribe el numero");
            numero = Console.ReadLine();

            EtapaVida(numero);
        }


        private static void EtapaVida(string numero)
        {   
            int pares = 0;
            int impares = 0;
            
            foreach (char i in numero) 
            {
                int umero = int.Parse(i.ToString());    
                if(umero % 2 == 0)
                {
                    pares += umero;
                }
                else
                {
                    impares += umero;
                }
            }


            Console.WriteLine($"La suma de numeros impares del numero dado es: {impares}");
            Console.WriteLine($"La suma de numeros pares del numero dado es: {pares}");



        }
    }
}

//--------------------------------------

//Funciones - Ejercicio 75


namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Escribe la letra");
            letra = char.Parse(Console.ReadLine()); 

            Letra(letra );
        }


        private static void Letra(char letra) 
        {
            string caracteristica  = string.Empty;
            int number = (int) letra;   

            if(number == 65 || number ==69 || number == 73 || number ==79 || number == 85)
            {
                caracteristica = "Es un vocal";
            }
            else { 
                if(number == 97 || number ==101 || number == 105 || number == 111 || number == 117)
                {
                    caracteristica = "Es una vocal";
                }
                else
                {
                    switch (number)
                    {
                        case int n when n > 96 && n<= 122:
                            caracteristica = "letra minincula";
                            break;
                        case int n when n > 65 && n <= 90:
                            caracteristica = "letra Mayuscula";
                            break;
                        case int n when n > 47 && n <= 57:
                            caracteristica = "numero";
                            break;
                        default:
                            caracteristica = "Simbolo";
                            break;
                    }

                }
            }
            Console.WriteLine($"La caracteristica del caracter ingresa es: {caracteristica}");

        }
    }
}


//--------------------------------------

//Funciones - Ejercicio 76


namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la altura del rectangulo");
            float Base= float.Parse(Console.ReadLine());   
            Console.WriteLine("Ingresa la Base del Rectangulo");
            float Altura = float.Parse(Console.ReadLine());


            AreaRectangulo(Base, Altura);   

        }


        private static void AreaRectangulo(float Base, float Altura)
        {

            float Area = Base * Altura;
            Console.WriteLine($"El area del rectangulo es: {Area}");    

        }
    }
}


//------------------------------------------


//Funciones - Ejercicio 77


namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el monto total de su compra");
            float Base= float.Parse(Console.ReadLine());    

            Console.WriteLine("¿Eres cliente afiliado(A) o Publico en general(G)?");
            char tipo = char.Parse(Console.ReadLine());

            Console.WriteLine("¿Deseas pagar de contado(C) o por Plazos(P)");
            char Pago = char.Parse(Console.ReadLine());


            if(Pago.ToString().ToLower() == "c")
            {
                Console.Write($"El pago total es {Base - Descuento(Pago, tipo, Base)}");    
            }
            else
            {
                if(Pago.ToString().ToLower() == "p")
                {
                    Console.Write($"El pago total es {Base - Recargo(Pago, tipo, Base)}");
                }
            }




        }


        private static float Recargo(char pago, char tipo, float monto)
        {
            if( tipo.ToString().ToLower() == "g")
            {
                if(pago.ToString().ToLower() == "p")
                {
                    float recargo = (float)(monto * 0.10);
                    return recargo;
                }

            }

            if(tipo.ToString().ToLower() == "a")
            {
                if (pago.ToString().ToLower() == "p")
                {
                    float recargo = (float)(monto * 0.05);

                    return recargo;
                }
                
            }

            return 0;


        }


        private static float Descuento(char pago, char tipo, float monto)
        {

            if (tipo.ToString().ToLower() == "a")
            {
                if (pago.ToString().ToLower() == "c")
                {
                    float descuento = (float)(monto * 0.20);
                    return descuento;
                }

            }


            if (tipo.ToString().ToLower() == "g")
            {
                if (pago.ToString().ToLower() == "c")
                {
                    float descuento = (float)(monto * 0.15);

                    return descuento;
                }

            }


            return 0;




        }

    }
}

//------------------------------------------


//Funciones - Ejercicio 78


namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {

            string numero = string.Empty;

            Console.WriteLine("Escriba el numero");
            numero = Console.ReadLine();


            Console.WriteLine($"El numero es {numero} y su inverso es {eversa(numero)}");

        }

        private static string eversa(string numero)
        {
            string newNumero = string.Empty;    

            for (int i = (char)(numero.Length - 1); i >= 0; i--)
            {

                newNumero += numero[i];
                
            }

            return newNumero;
        }



    }
}


//----------------------------------



//Funciones - Ejercicio 79


namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string palabra = string.Empty;

            Console.WriteLine("Escriba el numero");
            palabra = Console.ReadLine();

            if(palabra == eversa(palabra))
            {
                Console.WriteLine("Si es palindromo la palabra");
            }
            else
            {
                Console.WriteLine("No es Palindroma la palabra");

            }



        }

        private static string eversa(string palabra)
        {
            string newNumero = string.Empty;    

            for (int i = (char)(palabra.Length - 1); i >= 0; i--)
            {

                newNumero += palabra[i];
                
            }

            return newNumero;
        }



    }
}


//--------------------------------------

//Funciones - Ejercicio 80


namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2] { { 2, 2 }, { 2, 2 } };
            int[,] b = new int[2, 2] { { 2, 2 }, { 2, 2 } };

            int[,] sumaTotal = suma(a, b);


            foreach (int i in sumaTotal) {
             
                Console.WriteLine(i);
               
            }

        }

        private static int[,] suma(int[,] a, int[,] b) 
        {
            int[,] newSuma = new int[2,2];

            for (int i = 0; i < 2; i++)
            {
                for (global::System.Int32 j = 0; j < 2; j++)
                {
                    newSuma[i,j] = a[i, j] * b[i,j];
                }
            }


            return newSuma;
        }



    }
}