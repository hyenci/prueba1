using System;

class Program
{
    static void Main(string[] args)
    {
   
       Console.Write("INGRESE UN NUMERO ENTERO");
        int numeroEntero = Convert.ToInt32(Console.ReadLine());

        decimal numeroDecimal = Convert.ToDecimal(numeroEntero);

  
        Console.WriteLine($"EL RESULTADO ES: {numeroDecimal}");
    }
}
