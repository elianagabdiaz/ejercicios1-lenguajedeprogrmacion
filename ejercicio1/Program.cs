using System;

class Program
{
    static void Main()
    {
        string continuar;

        do
        {
            Console.WriteLine("COLEGIO DIOS ES BUENO");
            Console.WriteLine("\t\tCalificaciones del cuatrimestre\n");

            // pido los datos del estudiante, utilizo un do while para que se ejecute continuamente
            Console.Write("--Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("--Apellido: ");
            string apellido = Console.ReadLine();

            double sumaNotas = 0;
            double[] notas = new double[4];

            // aqui utilizo un tryparse para validar que el usuario ingrese un numero y que este entre 0 y 100, sino el programa se lo avisará
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Ingrese Nota {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 100)
                {
                    Console.Write($"Nota inválida. Ingrese Nota {i + 1} (0 a 100): ");
                }
                sumaNotas += notas[i];
            }

            double promedio = sumaNotas / 4.0;

            // para saber el literal según el promedio dado, utilizo un if else if else para asignar el valor correspondiente
            string literal;
            if (promedio >= 90)
            {
                literal = "A";
            }
            else if (promedio >= 80)
            {
                literal = "B";
            }
            else if (promedio >= 70)
            {
                literal = "C";
            }
            else
            {
                literal = "F";
            }

            // aqui se imprime la tabla con los datos del estudiante, las notas, el promedio y el literal
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Nombre\t\tApellido\tNota1\tNota2\tNota3\tNota4\tPromedio\tLiteral");
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{nombre}\t\t{apellido}\t\t{notas[0]}\t{notas[1]}\t{notas[2]}\t{notas[3]}\t{promedio:F1}\t\t{literal}");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");

            // aqui se pregunta al usuario si desea ingresar los datos de otro estudiante, si la respuesta es si el programa se reinicia, sino termina
            Console.Write("\n¿Desea ingresar los datos de otro estudiante? (si/no): ");
            continuar = Console.ReadLine().Trim().ToLower();

        } while (continuar == "si");

    }
}