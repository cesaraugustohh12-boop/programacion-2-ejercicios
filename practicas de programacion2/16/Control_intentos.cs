using System;

class ingreso
{
    static void Main(string[] args)
    {
        string claveSecreta = "unicda2026";
        int intentos = 0;
        int maximoIntentos = 3;
        bool acceso = false;

        while (intentos < maximoIntentos && !acceso)
        {
            Console.Write("Ingrese la contraseña: ");
            string claveIngresada = Console.ReadLine();

            if (claveIngresada == claveSecreta)
            {
                acceso = true;
                Console.WriteLine("Bienvenido al sistema");
            }
            else
            {
                intentos++;
                Console.WriteLine($"Contraseña incorrecta. Intentos restantes: {maximoIntentos - intentos}");
            }
        }

        if (!acceso)
        {
            Console.WriteLine("Acceso bloqueado. Ha superado el número máximo de intentos.");
        }
    }
}