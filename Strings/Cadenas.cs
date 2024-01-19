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


//Ejercicio 66


Console.WriteLine("Escribe la palabra:");
string nombre = Console.ReadLine();
string newNombre = String.Empty;

for (int i = nombre.Length - 1; i > -1; i--)
{
    newNombre += nombre[i];
}

if (newNombre.ToLower() == nombre.ToLower())
{
    Console.WriteLine($"Si es Palindroma la palabra: {nombre}");
}
else { 
    Console.WriteLine($"No es Palindroma la palabra: {nombre}");
}


//--------------------------

//Ejercicio 67

//Leer
Console.WriteLine("Escribe la Frase:");
string? nombre = Console.ReadLine();

//Separar
var nombres = new string[nombre.Length];
nombres = nombre.Split(' ');

//Variable cambiante
string newNombre = String.Empty;
int contador = 0;


foreach (var nomb in nombres)
{

    newNombre = "";
    for (int i = nomb.Length - 1; i > -1; i--)
    {
        newNombre += nomb[i];
    }


    if (newNombre.ToLower() == nomb.ToLower())
    {
        contador++;
    }

}

Console.WriteLine($"La cantidad de palabras palindromas que tiene la frase es: {contador}");


//--------------------------

//Ejercicio 68

//Leer
Console.WriteLine("Escribe la Frase:");
string? nombre = Console.ReadLine();

//Separar
var nombres = new string[nombre.Length];
nombres = nombre.Split(' ');

//Variable cambiante
string newNombre = String.Empty;
int contador = 0;


var palabrasAqui = new string[nombres.Length];


foreach (var nomb in nombres)
{
    for (int i = 0; i < nombres.Length; i++)
    {
        if (nomb.ToLower().Equals(nombres[i].ToLower()))  
        {
            contador++;
            palabrasAqui[i] = nomb; 
        }
    }
}

Console.WriteLine($"La cantidad de palabras que se repite son: {(contador - nombres.Length) / 2}");

//--------------------------


//Ejercicio 69


//Leer
Console.WriteLine("Escribe la Frase:");
string? nombre = Console.ReadLine();

string newFrase = string.Empty;
int newNumbrer = 0;

foreach (var nomb in nombre)
{
    newNumbrer = (int) nomb + 2;
    newFrase += (char) newNumbrer;
}


Console.WriteLine($"La nueva frase encriptada es:  {newFrase}");


//--------------------------


//Ejercicio 70

//Leer
Console.WriteLine("Escribe la Frase encriptada:");
string? nombre = Console.ReadLine();

string newFrase = string.Empty;
int newNumbrer = 0;

foreach (var nomb in nombre)
{
    newNumbrer = (int) nomb - 2;
    newFrase += (char) newNumbrer;
}


Console.WriteLine($"La frase desencriptada es: {newFrase}");


