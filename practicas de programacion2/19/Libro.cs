using System;

class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnioPublicacion { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
       
        Libro miLibro = new Libro();
        miLibro.Titulo = "Cien Años de Soledad";
        miLibro.Autor = "Gabriel García Márquez";
        miLibro.AnioPublicacion = 1967;

        // Se muestran sus valores por consola
        Console.WriteLine($"Título: {miLibro.Titulo}");
        Console.WriteLine($"Autor: {miLibro.Autor}");
        Console.WriteLine($"Año de publicación: {miLibro.AnioPublicacion}");
    }
}