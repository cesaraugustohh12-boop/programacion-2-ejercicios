using System;

class tabla
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Tabla de multiplicar del {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}