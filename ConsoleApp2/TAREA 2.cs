//EJERCICIO 1

namespace Edad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿cuantos años tienes? ");
            byte edad = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("No aparentas tener esa edad ");
        }
    }
}



//Ejercicio 2
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor,Ingresar el primer número:");
        string numero1Texto = Console.ReadLine();
        byte numero1 = byte.Parse(numero1Texto);

        Console.WriteLine("Por favor,Ingresar el segundo número:");
        string numero2Texto = Console.ReadLine();
        byte numero2 = byte.Parse(numero2Texto);

        ushort resultado = (ushort)(numero1 * numero2);

        Console.WriteLine("La multiplicación de " + numero1 + " y " + numero2 + " es: " + resultado);
    }
}


//Ejercico 3 
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor,Ingresar el primer número entero: ");
        long numero1 = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Por favor,Ingresar el segundo número entero: ");
        long numero2 = Convert.ToInt64(Console.ReadLine());

        long suma = numero1 + numero2;
        long resta = numero1 - numero2;
        long Multiplicacion = numero1 * numero2;

        Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " es: " + suma);
        Console.WriteLine("La resta de " + numero1 + " y " + numero2 + " es: " + resta);
        Console.WriteLine("La multiplicación de " + numero1 + " y " + numero2 + " es: " + Multiplicacion);

        Console.ReadLine();
    }
}
