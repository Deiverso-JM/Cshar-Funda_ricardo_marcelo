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
