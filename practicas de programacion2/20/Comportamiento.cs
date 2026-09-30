using System;

class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnioPublicacion { get; set; }

    // Método dentro de la clase: imprime la información automáticamente
    public void MostrarDetalles()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Año de publicación: {AnioPublicacion}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Libro miLibro = new Libro();
        miLibro.Titulo = "Cien Años de Soledad";
        miLibro.Autor = "Gabriel García Márquez";
        miLibro.AnioPublicacion = 1967;

        // Se invoca el método del objeto, en vez de escribir los WriteLine en el Main
        miLibro.MostrarDetalles();
    }
}