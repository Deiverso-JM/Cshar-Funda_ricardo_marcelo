//Ejercicio  41


double cuadrados = 0;
double cubos = 0;



for (int i = 0; i < 101; i++)
{
    cuadrados += Math.Pow(i, 2);
    cubos += Math.Pow(i, 3);
}


Console.WriteLine("La suma de cuadrados es:");
Console.WriteLine(cuadrados);
Console.WriteLine("La suma de cubos es:");
Console.WriteLine(cubos);


//------------------------------------


//Ejercicio 42

int sumatoria = 0;
int cantidad = 0;


for (int i = 1; i <= 10; i++)
{

    if (i % 3 == 0 || i % 5 == 0)
    {
        sumatoria += i;
        cantidad++;
        Console.WriteLine(sumatoria);
    }
}


Console.WriteLine("La sumatoria es :");
Console.WriteLine(sumatoria);
Console.WriteLine("La cantidad es: ");
Console.WriteLine(cantidad);


//------------------------------------

//Ejercicio 43

Console.WriteLine("Escribe el numero A");
int desde = int.Parse( Console.ReadLine());
Console.WriteLine("Escribe el numero B");

int hasta = int.Parse(Console.ReadLine());
double cantidadPares = 0;
double cantidadImpares = 0;
double cantidadTres = 0;

double sumaImpares = 0;
double sumaPares = 0;
double sumaTres = 0;

for (int i = desde; i <=hasta; i++)
{
    Console.WriteLine(i);
   if(i % 2 == 0)
    {
        cantidadPares++;
        sumaPares += i;
    }
   else
    {
        cantidadImpares++;
        sumaImpares += i;
    }

    if (i % 3 == 0)
    {
        cantidadTres++;
        sumaTres += i;
    }
   
}

Console.WriteLine($"Cantidad de numeros impares: {cantidadImpares} y suma : {sumaImpares}");
Console.WriteLine($"Cantidad de numeros Pares: {cantidadPares} y suma: {sumaPares}");
Console.WriteLine($"Cantidad de numeros multiplos de 3: {cantidadTres} y suma : {sumaTres}");

//------------------------------------


//ejericio 44

int inicial = 1;
int segundo = 1;
int cantidad = 0;
int cantidadNumero = 0;
int suma = 0;


Console.WriteLine("Escribe el numero N");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i <=n; i++)
{
    if(cantidadNumero < n)
    {
        suma += inicial;
        cantidad++;
        inicial = segundo;
        segundo = cantidadNumero;
        cantidadNumero = inicial + segundo;
        continue;
    }
    break;
}


Console.WriteLine($"La cantidad de numeros menores es: {cantidad}");
Console.WriteLine($"La suma de numeros menores a es: {suma}");

//------------------------------------

//Ejercicio 45

Console.WriteLine("Escribe un numero:");
int n = int.Parse(Console.ReadLine());

int n1=0, n2, n3;

int cantidad = 0;
int contador = 0;
int acumulador = 1;


for (int i = 1; i <= n; i++)
{
    acumulador = 0;
    n1 = i; 
    while (n1 > 0)
    {
        n2 = n1 % 10;
        acumulador = (acumulador * 10) + n2; 
        n1 = (n1 - n2) / 10;
    }
    if(acumulador == i )
    {
        cantidad++;
    }


}
Console.WriteLine("la cantidad de numeros Capicua es:");
Console.WriteLine(cantidad);


//------------------------


//Ejercicio 46
Console.WriteLine("Escribe el divisor");

int n = int.Parse(Console.ReadLine());
int n1 = 0, n2 = 0;
int multiplos = 0;


int cifras = 0;
for (int i = 0;i<= 0; i++)
{
    n1 = n;
	while (n1> 0)
	{
        n2 = n1 % 10;
        n1 = (n1 - n2) / 10;
		cifras++;
    }

    for (int j = 1; j <= n; j++)
    {
        multiplos += j % cifras  == 0 ? 1 : 0;
        
    }

}



Console.WriteLine($"La cantidad de multiples es: {multiplos}");


//----------------------

//Ejercicio 47

using MathNet.Numerics;

Console.WriteLine("Ingresa X:");
int x = int.Parse(Console.ReadLine()); 
Console.WriteLine("Ingresa N:");
int n = int.Parse(Console.ReadLine());

double serie = 0;

for (int i = 0; i <= n ; i++)
{
    serie += (Math.Pow(x, i) / SpecialFunctions.Factorial(i));
}

//----------------------

//Ejercicio 48

Console.WriteLine("Escriba la cantidad de objetos");
int n = int.Parse(Console.ReadLine());

int cantidad = 1;

for (int i = 2; i <= n; i++)
{   
    cantidad *= i;
    
}

Console.WriteLine($"La cantidad de veces que se puede organizar un objeto es: {cantidad}");


//----------------------

// Ejercicio 49 

using System.Runtime.CompilerServices;

Console.WriteLine("Escribe la cantidad de numeros:");
int n = int.Parse(Console.ReadLine());

int contador=0, n1, cantidad = 0;



for (int i = 0; i <= n; i++)
{
    contador = 0;
    n1 = i;
    for (int j = 1; j <= n1; j++)
    {
        if (n1 % j == 0)
        {
            contador++;
        }
    }

    if(contador == 2)
    {
        cantidad++;
    }

    

}


Console.WriteLine($"Cantidad de numeros primos es: {cantidad}");



//----------------------

// Ejercicio 50

Console.WriteLine("Escribe el rango de numero:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Escribe el numero de cifras de numero:");
int numeroCifras = int.Parse(Console.ReadLine());



int n1 = 0, n2, n3, cifras=0;

int cantidad = 0;
int contador = 0;
int acumulador = 1;


for (int i = 1; i <= n; i++)
{
    cifras= 0;
    acumulador = 0;
    n1 = i;

    while (n1 > 0)
    {
        cifras++;
        n2 = n1 % 10;
        acumulador = (acumulador * 10) + n2;
        n1 = (n1 - n2) / 10;
    }
    if (acumulador == i && cifras == numeroCifras)
    {
        cantidad++;
    }


}
Console.WriteLine("la cantidad de numeros Capicua es:");
Console.WriteLine(cantidad);

