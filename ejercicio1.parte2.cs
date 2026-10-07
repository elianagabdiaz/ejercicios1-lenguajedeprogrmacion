using System;

class Program
{
    static void Main()
    {

        Console.Write("Primer número: ");
        double num1;
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Ingrese un número válido: ");
        }


        Console.Write("Segundo número: ");
        double num2;
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Ingrese un número válido: ");
        }

        Console.WriteLine("\n---------------------------------");


        // suma
        double suma = num1 + num2;
        Console.WriteLine($"Suma: {num1} + {num2} = {suma}");

        // resta
        double resta = num1 - num2;
        Console.WriteLine($"Resta: {num1} - {num2} = {resta}");

        // multiplicación
        double multiplicacion = num1 * num2;
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {multiplicacion}");

        // división con validación de división entre cero
        if (num2 != 0)
        {
            double division = num1 / num2;
            Console.WriteLine($"División: {num1} / {num2} = {division}");
        }
        else
        {
            Console.WriteLine("División: No se puede dividir entre cero.");
        }

        // raíz cuadrada de cada valor con validación para números negativos
        if (num1 >= 0)
        {
            Console.WriteLine($"Raíz cuadrada de {num1}: {Math.Sqrt(num1):F2}");
        }
        else
        {
            Console.WriteLine($"Raíz cuadrada de {num1}: No se puede calcular en números reales");
        }

        if (num2 >= 0)
        {
            Console.WriteLine($"Raíz cuadrada de {num2}: {Math.Sqrt(num2):F2}");
        }
        else
        {
            Console.WriteLine($"Raíz cuadrada de {num2}: No se puede calcular en números reales ");
        }

    }
}
