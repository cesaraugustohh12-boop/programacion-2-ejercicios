using System;

class Estudiante
{
    public string Nombre { get; set; }
    public string Matricula { get; set; }
    public double Calificacion { get; set; }

    // Método que evalúa si el estudiante está aprobado
    public bool EstaAprobado()
    {
        return Calificacion >= 70;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Calificación: {Calificacion}");

        if (EstaAprobado())
        {
            Console.WriteLine("Estado: Aprobado");
        }
        else
        {
            Console.WriteLine("Estado: Reprobado");
        }
    }
}

class integrador
{
    static void Main(string[] args)
    {
        
        Estudiante estudiante1 = new Estudiante();
        estudiante1.Nombre = "María Pérez";
        estudiante1.Matricula = "2026-0145";
        estudiante1.Calificacion = 85;

        estudiante1.MostrarDetalles();
    }
}