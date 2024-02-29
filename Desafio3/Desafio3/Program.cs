using System;

class Program
{
    public static int SumarNumeros()
    {
        int resultado = 0;

        try
        {
            Console.Write("Ingresa el primer número: ");
            string input1 = Console.ReadLine();
            int num1 = int.Parse(input1);

            Console.Write("Ingresa el segundo número: ");
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input2);

            resultado = num1 + num2;
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese valores numéricos válidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Bloque Finally");
        }

        return resultado;
    }

    static void Main()
    {
        int resultado = SumarNumeros();

        if (resultado != 0)
        {
            Console.WriteLine($"La suma de los números es: {resultado}");
        }

        Console.ReadLine();
    }
}
