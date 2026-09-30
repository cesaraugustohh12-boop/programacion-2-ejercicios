using System;

class acceso
{
    static void Main(string[] args)
    {
        string claveSecreta = "unicda2026";

        Console.Write("Ingrese la contraseña: ");
        string claveIngresada = Console.ReadLine();

        if (claveIngresada == claveSecreta)
        {
            Console.WriteLine("Bienvenido al sistema");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta");
        }
    }
}