using System;

class pares_nones
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} es par.");
        }
        else
        {
            Console.WriteLine($"{numero} es impar.");
        }
    }
}