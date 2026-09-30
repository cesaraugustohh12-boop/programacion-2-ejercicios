using System;

class Saludo
{
    static string Saludar(string nombre)
    {
        return $"Bienvenido/a, {nombre}, a la Universidad Domínico Americano";
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        string mensaje = Saludar(nombre);
        Console.WriteLine(mensaje);
    }
}