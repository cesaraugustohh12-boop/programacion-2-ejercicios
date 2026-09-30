using System;

class descuento
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el monto total de la compra: ");
        double monto = Convert.ToDouble(Console.ReadLine());

        if (monto > 5000)
        {
            double descuento = monto * 0.10;
            double nuevoTotal = monto - descuento;
            Console.WriteLine($"Se aplicó un 10% de descuento. Nuevo total: {nuevoTotal}");
        }
        else
        {
            Console.WriteLine($"No aplica descuento. Total: {monto}");
        }
    }
}