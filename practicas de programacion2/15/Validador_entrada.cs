using System;

class validador
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número positivo: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        while (numero <= 0)
        {
            Console.Write("Número inválido. Ingrese un número positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"Gracias, ingresó un número válido: {numero}");
    }
}