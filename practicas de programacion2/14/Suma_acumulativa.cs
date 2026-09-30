using System;

class acumulativa
{
    static void Main(string[] args)
    {
        int suma = 0;

        for (int i = 1; i <= 100; i++)
        {
            suma += i;
        }

        Console.WriteLine($"La suma de todos los números del 1 al 100 es: {suma}");
    }
}