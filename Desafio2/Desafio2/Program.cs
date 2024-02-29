using System;

class Operaciones
{
    public static int Sumar(int a, int b)
    {
        return a + b;
    }

    public static int Restar(int a, int b)
    {
        return a - b;
    }

    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public static double Dividir(int a, int b)
    {
        if (b != 0)
        {
            return (double)a / b;
        }
        else
        {
            Console.WriteLine("No se puede dividir por cero.");
            return double.NaN;
        }
    }

    public static void Main()
    {
        Console.Write("Ingresa el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Suma: {Sumar(num1, num2)}");
        Console.WriteLine($"Resta: {Restar(num1, num2)}");
        Console.WriteLine($"Multiplicación: {Multiplicar(num1, num2)}");
        Console.WriteLine($"División: {Dividir(num1, num2)}");

        Console.ReadLine();
    }
}
