using System;

class mayoror_edad
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la edad de la persona: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Es mayor de edad.");
        }
        else
        {
            Console.WriteLine("Es menor de edad.");
        }
    }
}