//Ejercicio 61

Console.WriteLine("Escribe tu nombre:");
string nombre = Console.ReadLine();


Console.WriteLine($"Bienvenido, Sr(a) {nombre} a su tienda de preferencia");

//--------------------------

//Ejercicio 62

Console.WriteLine("Escribe tu nombre:");
string nombre = Console.ReadLine();
string newNombre = String.Empty;

for (int i = nombre.Length -1 ; i > -1; i--)
{
    newNombre += nombre[i]; 
}
Console.WriteLine($"Su nombre invertido es: {newNom}");

//--------------------------

//Ejercicio 63

Console.WriteLine("Escribe tu frase:");
string frase = Console.ReadLine();
frase = frase.Replace(' ', '*');
Console.WriteLine($"Tu frase es: {frase}");

//--------------------------


//Ejercicio 64

Console.WriteLine("Escribe tu letra:");
char letra = char.Parse(Console.ReadLine());    


if((int) letra > 122 ||(int) letra <65)
{
    Console.WriteLine("No es una letra, es un simbolo");
    return;
}

if(letra.ToString() == letra.ToString().ToLower())
{
    Console.WriteLine("Es Minuscula");
}
else if(letra.ToString()  == letra.ToString().ToUpper())
{
    Console.WriteLine("Es Mayuscula");
}

//--------------------------


//Ejercicio 65

Console.WriteLine("Escribe tu frase:");
string frase = Console.ReadLine();

Console.WriteLine("Escribe tu palabra");

string palabra = Console.ReadLine();

if (frase.Contains(palabra))
{
    Console.WriteLine("Si la tiene");
}
else
{
    Console.WriteLine("No la tiene");
}

//--------------------------
