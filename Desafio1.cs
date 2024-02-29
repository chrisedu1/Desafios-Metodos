using System;

namespace Desafio1
{
    class Promedio
    {
        public static void Main(string[] args)
        {
            string nombre;

            Console.Write("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);

            Console.WriteLine("Promedio de 3 meses");

            Console.Write("Ingresa la cantidad del primer mes: ");
            string dato = Console.ReadLine();
            int n1 = int.Parse(dato);

            Console.Write("Ingresa la cantidad del segundo mes: ");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);

            Console.Write("Ingresa la cantidad del tercer mes: ");
            dato = Console.ReadLine();
            int n3 = int.Parse(dato);

            int suma = n1 + n2 + n3;
            double promedio = (double)suma / 3;

            Console.WriteLine("El resultado de la suma es: {0}", suma);
            Console.WriteLine("El promedio es: {0}", promedio);

            Console.Read();
        }
    }
}