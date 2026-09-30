using System;

class edad
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el año actual: ");
        int anioActual = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el año de nacimiento: ");
        int anioNacimiento = Convert.ToInt32(Console.ReadLine());

        int edad = anioActual - anioNacimiento;

        Console.WriteLine($"La edad aproximada del estudiante es: {edad} años");
    }
}