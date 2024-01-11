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



