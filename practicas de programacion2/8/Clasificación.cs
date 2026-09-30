using System;

class clasificacion
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la calificación (0-100): ");
        double calificacion = Convert.ToDouble(Console.ReadLine());

        if (calificacion >= 70)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
}