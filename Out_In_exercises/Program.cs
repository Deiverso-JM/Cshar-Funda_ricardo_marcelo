using System;

namespace _01{
    class programa{
        static void Main(string[] args){
            
            //PROBLEMA 1            
     
            int a,b;
            int res;

            Console.WriteLine("Escriba el primer numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero: ");
            b = int.Parse(Console.ReadLine());

            res = a+b;

            Console.WriteLine("La suma es: " + res);

            res = a-b;

            Console.WriteLine("La resta es: " + res);

            //PROBLEMA 2
            
            int cont;

            Console.WriteLine("Escriba el primer numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero: ");
            b = int.Parse(Console.ReadLine());
            
            cont=Math.Abs(a-b);
            Console.WriteLine("La cantidad es de numeros enteros que los incluyen son: " + cont);



            //PROBLEMA 3

            float centimetros, metros, milimetros, decimetros;

            Console.WriteLine("Escribe la cantidad de milimetros : ");
            milimetros = float.Parse(Console.ReadLine());

            metros = milimetros/1000;
            centimetros = milimetros / 10;
            decimetros = milimetros / 100;

            Console.WriteLine("La canntidad en milimetros es "+ milimetros + " sus equivalencias son :");
            Console.WriteLine("Metros: " + metros + "m, en Centimentros: " + centimetros + "cm , en decimetros : " + decimetros + "dm" );


            //PROBLEMA 4

            double c,d;

            c= Convert.ToInt16(((4*Math.Pow(a,4))+(3*(b)*(a))+Math.Pow(b,2))/(Math.Pow(a,2)-Math.Pow(b,2)));

            d= Convert.ToInt16((((3*Math.Pow(c,2))+a+b)/4));
    

            Console.WriteLine("c es: " + c);
            Console.WriteLine("d es: "+d );

            //Problema 5

            int numero1, numero2, numero3, numero4;

            Console.WriteLine("Escriba el numero 1:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el numero 2:");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el numero 3:");
            numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el numero 4:");
            numero4 = int.Parse(Console.ReadLine());

            int total = numero1+numero2+numero3+numero4;

            numero1 = ((numero1*100)/total);
            numero2 = ((numero2*100)/total);
            numero3 = ((numero3*100)/total);
            numero4 = ((numero4*100)/total);

            Console.WriteLine("El numero en porcentaje del primero es: " + numero1 + "% del segundo es: " + numero2 + "% del tercero es: "+ numero3 + "% del cuarto es: " + numero4 + "%");

            //Problema 6

            float lado;
            float Areac, Perimetroc;

            Console.WriteLine("Escribe la longitud o tamaño de un lado del cuadrado");
            lado = float.Parse(Console.ReadLine());

            Areac = lado*lado;
            Perimetroc= lado*4;

            Console.WriteLine("El area del cuadrado es: "+ Areac + " y su perimetro es: " + Perimetroc);

            //Problema 7

            int horas, minutos, segundo;

            Console.WriteLine("Escribe la cantidad de horas");
            horas = int.Parse(Console.ReadLine());


            minutos = horas*60;
            segundo = minutos*60;

            Console.WriteLine("La equivalencia de "+ horas + " Dadas es : " + " en minutos : " + minutos + " en segundos " + segundo);


            //Problema 8

            double gradosf, gradosc, gradosk;

            Console.WriteLine("Escribe la cantidad de grados F");
            gradosf = float.Parse(Console.ReadLine());

            gradosc = 5*(gradosf-32)/9;  
            gradosk = 5*(gradosf-32)/9 + 273.15; 

            Console.WriteLine("La equivalencia de grados C es: " + gradosc + " Y la equivalencia en grados K es : "+ gradosk);

            //Problema 9

            float baser, altura;
            float Arear, Perimetror;

            Console.WriteLine("Escribe la altura del rectangulo");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Escribe la base del rectangulo");
            baser = float.Parse(Console.ReadLine());

            Arear = baser*altura;

            Perimetror= (baser*2)+(altura*2);

            Console.WriteLine("El area del cuadrado es: "+ Arear + " y su perimetro es: " + Perimetror);

            //Problema 10

            float gradoss, gradoscen;

            Console.WriteLine("Escribe la cantidad de grados sexagesimales");
            gradoss = int.Parse(Console.ReadLine());

            gradoscen = (gradoss*200)/180;

            Console.WriteLine("La equivalencia a grados centesimales es: " + gradoscen);




        
        
        }
    }

}