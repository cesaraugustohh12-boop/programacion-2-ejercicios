using System;

class rectangulo
{
    static void Main(string[] args)
    {
       
        Console.Write("Ingrese la base del rectángulo: ");
        double base_ = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Ingrese la altura del rectángulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        
        double area = base_ * altura;

        
        Console.WriteLine($"El área del rectángulo es: {area}");
    }
}