using System;

class  division
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número entero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número entero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int cociente = numero1 / numero2;
        int residuo = numero1 % numero2;

        Console.WriteLine($"Cociente: {cociente}");
        Console.WriteLine($"Residuo: {residuo}");
    }
}