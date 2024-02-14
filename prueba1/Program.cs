using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número entero
        Console.Write("Ingrese un número entero: ");
        int numeroEntero = Convert.ToInt32(Console.ReadLine());

        // Convertir el número entero a decimal
        decimal numeroDecimal = Convert.ToDecimal(numeroEntero);

        // Mostrar el resultado
        Console.WriteLine($"El número {numeroEntero} en decimal es: {numeroDecimal}");
    }
}

