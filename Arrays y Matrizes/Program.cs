//Ejercicio 51

double promedio = 0;
int[] numbers = new int[4];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Ingres el numero: {i}");
    numbers[i] = int.Parse(Console.ReadLine());
    promedio += numbers[i];
}

Console.WriteLine($"El promedio de los numeros es: {(promedio/numbers.Length)} y la suma es: {promedio}");

//-------------------------------------

//Ejercicio 52


int mayor = 0;
int menor = 0;
int[] numbers = new int[4];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Ingres el numero: {i}");
    numbers[i] = int.Parse(Console.ReadLine());
    if (numbers[i] > mayor)
    {
        mayor = numbers[i];
    }

}
menor = mayor-1;
Console.WriteLine(menor);
for (int i = 0; i < numbers.Length; i++)
{
    if (menor >= numbers[i])
    {
        menor = numbers[i];
    }

    

}

Console.WriteLine($"El numero mayor es: {mayor} y el menor es: {menor}");

//-------------------------


//Ejercicio 53

Console.WriteLine("Escribe el numero N:");
int n = int.Parse(Console.ReadLine());
int[] numbers = new int[6];
int multiplos = 0;
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Ingres el numero: {i}");
    numbers[i] = int.Parse(Console.ReadLine());

    if (numbers[i] % n == 0)
    {
        multiplos++;
    }

}


Console.WriteLine($"La cantidad de multipletos de n son: {multiplos}");

//-------------------------

//Ejercicio 54

Console.WriteLine("Escribe el la forma que quieres aparecer los numeros: A.Decendiente, B.Acendente");
string n = Console.ReadLine();

Console.WriteLine(n);

int[] numbers = new int[6] { 4, 5, 2, 4, 3, 5 };
int LI = 0, tem;
int LS = numbers.Length - 1;

if ( n == "A")
{
    for (int i = LI; i <= LS - 1; i++) 
    {
        for (int j= LI; j<=LS - 1; j++) {

            if (numbers[j] > numbers[j+1]) { 
                tem = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = tem;
            }

        }
    }

}

if(n == "B") {
    for (int i = LI; i <= LS - 1; i++)
    {
        for (int j = LI; j <= LS - 1; j++)
        {

            if (numbers[j] <numbers[j + 1])
            {
                tem = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = tem;
            }

        }
    }

}


for(int i = 0; i< numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);  
}


//---------------------



//Ejercicio 55
int cantidad = 0;
int[] numbers = new int[4];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Ingres el numero: {i}");
    numbers[i] = int.Parse(Console.ReadLine());
}


for (int i = 0; i < numbers.Length; i++)
{
    for (global::System.Int32 j = 0; j < numbers.Length; j++)
    {
        if (numbers[i] == numbers[j])
        {
            cantidad++;
        }
    }
}

Console.WriteLine($"la cantidad de numeros repetidos es: {cantidad - numbers.Length}");

//---------------------


//Ejercicio 56

int[,] numbers = new int[3,2];
int[] sumas = new int[3];

for (int i = 0; i < 3; i++)
{
    for (global::System.Int32 j = 0; j < 2 ; j++)
    {
        Console.WriteLine($"Escribe numero {i} :");
        int n = int.Parse(Console.ReadLine());
        numbers[i,j] = n;
        sumas[i] += numbers[i, j];
    }
    Console.WriteLine("------------");
}


for (int i = 0;i < sumas.Length; i++)
{
    Console.WriteLine($"La suma de la fila {i} es: {sumas[i]}");
}


//----------------------

//Ejercicio 57

int[,] numbers = new int[3,2];
int acumulador = 0;

for (int i = 0; i < 3; i++)
{
    for (global::System.Int32 j = 0; j < 2 ; j++)
    {
        Console.WriteLine($"Escribe numero {i} :");
        int n = int.Parse(Console.ReadLine());
        numbers[i,j] = n;
        acumulador += numbers[i, j];
    }
}


Console.WriteLine($"El promedio aritmetico es: {acumulador/numbers.Length}");


//----------------------

//Ejercicio 58

int[,] numbers = new int[2, 3];
int acumulador = 0;

Console.WriteLine("Ingresa el valor de K:");
int k = int.Parse(Console.ReadLine());

for (int i = 0; i < 2; i++)
{
    for (global::System.Int32 j = 0; j < 3; j++)
    {
        Console.WriteLine($"Escribe numero {i} :");
        int n = int.Parse(Console.ReadLine());
        numbers[i, j] = n * k;
        acumulador += numbers[i, j];
    }

    Console.WriteLine("-------------");
}


Console.WriteLine($"La suma de los numeros es: {acumulador}");


//-------------------------------

//Ejercicio 59

int[,] B = new int[2, 2] { {2,2 },{2,2 } };
int[,] A = new int[2, 2] { { 2, 2}, {2, 2} };

int[,] C = new int[2, 2];

for (int i = 0; i < 2; i++)
{
    for (global::System.Int32 j = 0; j < 2; j++)
    {
        C[i, j] = A[i,j] * B[i, j];
        Console.Write(C[i, j]);
    }
    Console.WriteLine(" ");
}

//-------------------------------

//Ejercicio 60

int[] columnas = new int[4] {0,0,0,0 };
int[,] matriz = new int[4, 3] { {5,2,1 },{4,10,23 }, {20,144,23 }, {13,23,5 } };
int contador = 0;

for (int i = 0; i < 4; i++)
{

    for (global::System.Int32 j = 0; j < 3; j++)
    {
        if (matriz[i, j] > columnas[i])
        {
            columnas[i] = matriz[i, j];
        }

    }

}


foreach (var numeros in columnas)
{
    Console.WriteLine($"El numero mayor de la columna: {contador++} es: {numeros}");
    
}


