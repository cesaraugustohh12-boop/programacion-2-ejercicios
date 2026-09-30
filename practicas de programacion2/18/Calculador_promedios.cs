using System;

class promedios
{
   
    static double CalcularPromedio(double nota1, double nota2, double nota3)
    {
        double promedio = (nota1 + nota2 + nota3) / 3;
        return promedio;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese la primera calificación: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la segunda calificación: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la tercera calificación: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double resultado = CalcularPromedio(nota1, nota2, nota3);

        Console.WriteLine($"El promedio de las tres calificaciones es: {resultado}");
    }
}