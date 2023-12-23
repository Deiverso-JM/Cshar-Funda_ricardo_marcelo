using System;

namespace EstruturasMultiples
{
    class program
    {
        static void Main(String[] args)
        {

            //PROBLEMA 31

            int fibo, fibo2, numero, i, suma = 0;

            Console.WriteLine("Escribe hasta que numero quieres la secuencia: ");
            numero = int.Parse(Console.ReadLine());
            i = 0;
            fibo = 0;
            fibo2 = 1;
            Console.Write(0);
            Console.Write(1);
            while (i <= numero)
            {
                suma = fibo + fibo2;
                Console.Write(suma);
                fibo = fibo2;
                fibo2 = suma;
                i += 1;
            }



            //PROBLEMA 32
            int n;

            int pares, impares;

            Console.WriteLine("Escribe hasta que numero quieres que llegue:");
            n = int.Parse(Console.ReadLine());
            i = 0;
            impares = 0;
            pares = 0;
            while (i <= n)
            {
                if (i % 5 == 0)
                {

                }
                else
                {
                    if (i % 2 == 0)
                    {
                        pares += 1;
                    }
                    else
                    {
                        impares += 1;
                    }
                }

                i += 1;

            }

            Console.WriteLine($"Numeros impares: {impares} y numeros pares {pares}");

            //PROBLEMA 33

            Console.WriteLine("Escribe hasta que numero quieres que llegue:");
            n = int.Parse(Console.ReadLine());
            i = 0;
            int sumador, multiplicador;
            sumador = 0;
            multiplicador = 1;

            while (i <= n)
            {
                if (i % 3 == 0)
                {
                    sumador += i;
                    if (i > 0)
                    {
                        multiplicador *= i;
                    }
                }
                i += 1;
            }

            Console.WriteLine($"Sumatoria de numeros: {sumador} y multiplicacion de estos {multiplicador} multiples de 3");

            //PROBLEMA 34

            Console.WriteLine("Escribe el numero :"); // 0105045 3
            n = int.Parse(Console.ReadLine());
            int ceros, aux;
            ceros = 0;
            aux = 0;
            i = 0;
            while (n > 0.0)
            {

                aux = n % 10;
                if (aux == 0)
                {
                    ceros += 1;
                }

                n = n / 10;
                if (n == 0)
                {
                    while (i <= 1)
                    {
                        aux = n % 10;
                        if (aux == 0)
                        {
                            ceros += 1;
                        }
                        i = i + 1;
                        break;
                    }
                }
            }

            Console.WriteLine($"La cantidad de ceros es {ceros}");


            //PROBLEMA 35
            int digito, numeroEncontrado;

            Console.WriteLine("Escribe el numero :");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el digito que desea saber si esta: ");
            digito = int.Parse(Console.ReadLine());
            i = 0;
            numeroEncontrado = 0;
            while (n > 0)
            {
                aux = n % 10;
                if (aux == digito)
                {
                    numeroEncontrado += 1;
                }
                n = n / 10;
            }
            if (numeroEncontrado >= 1)
            {
                Console.WriteLine("En el numero si existe el digito ");

            }


            //PROBLEMA 36
            int n, i;

            int pares, impares, contador;

            Console.WriteLine("Escribe hasta que numero quieres que llegue:");
            n = int.Parse(Console.ReadLine());
            i = 1;
            impares = 0;
            pares = 0;
            contador = 0;
            while (i <= n)
            {
                if (i == 0 || i == 1)
                {
                    contador += 1;
                }
                else if (i % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }
                i += 1;
            }

            Console.WriteLine($"Porcentaje de los numeros impares: {(impares * 100) / n}% y numeros pares {(pares * 100) / n}% y los numeros neutros {(contador * 100) / n}%");


            //PROBLEMA 37

            int i = 2, n, i2 = 1;
            int contador = 0, cantidad = 0;

            Console.WriteLine("Escribe el rango de numeros para saber cuantos primos tiene:");
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {

                while (i2 <= n)
                {

                    if (i % i2 == 0)
                    {
                        contador += 1;
                    }
                    i2 += 1;
                }
                if (contador > 2)
                {
                    contador = 0;
                    i2 = 1;
                }
                else if (contador == 2)
                {
                    cantidad += 1;
                    contador = 0;
                    i2 = 1;
                }
                i += 1;
            }

            Console.WriteLine(cantidad);

            //PROBLEMA 38
            int n, b, d, i = 1;
            int l = 1;


            Console.WriteLine("Escriba el numero");
            n = int.Parse(Console.ReadLine());


            b = n;

            while (l > 0)
            {
                d = b / 10;
                b = b % 10;
                i = (d * 10) + b;
                Console.WriteLine(i);

                if (n == i)
                {
                    Console.WriteLine("Si es capicua");
                    break;
                }
                else
                {
                    Console.WriteLine("No es capicua");
                }

                l++;

            }





            //PROBLEMA 39
            double numeroUno = 120, numeroDos = 156, nuevoNumero;
            double residuo, division;

            while (numeroDos > 0)
            {

                residuo = numeroUno % numeroDos;
                division = numeroUno / numeroDos;
                nuevoNumero = (residuo * division) + numeroDos;
                numeroUno = numeroDos;
                numeroDos = residuo;

                if (numeroDos == 0)
                {
                    Console.WriteLine("Encontramos eso");
                    Console.WriteLine(numeroUno);
                    break;
                }
            }

            //PROBLEMA 40
            double numeroUno = 240, numeroDos = 180;
            double MC = 1;
            int divsor = 2;

            while (divsor < 11)
            {
                while (numeroUno % divsor == 0 && numeroDos % divsor == 0)
                {
                    MC = MC * divsor;
                    numeroUno = numeroUno / divsor;
                    numeroDos = numeroDos / divsor;
                }
                divsor++;
            }

            Console.WriteLine(MC);
















        }
    }
}