using System;

class calculadora
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el operador (+, -, *, /): ");
        string operador = Console.ReadLine();

        double resultado;

        switch (operador)
        {
            case "+":
                resultado = numero1 + numero2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case "-":
                resultado = numero1 - numero2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case "*":
                resultado = numero1 * numero2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case "/":
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else
                {
                    Console.WriteLine("Error: no se puede dividir entre cero.");
                }
                break;
            default:
                Console.WriteLine("Operador no válido.");
                break;
        }
    }
}