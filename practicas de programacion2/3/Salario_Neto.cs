using System;

class salario
{
    static void Main(string[] args)
    {
        
        Console.Write("Ingrese el pago por hora: ");
        double pagoPorHora = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Ingrese las horas trabajadas en la semana: ");
        double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

        
        double salarioBruto = pagoPorHora * horasTrabajadas;

        
        Console.WriteLine($"El salario correspondiente a la semana es: {salarioBruto}");
    }
}