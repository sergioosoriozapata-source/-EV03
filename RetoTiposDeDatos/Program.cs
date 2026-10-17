using System;

namespace RetoTiposDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("  RETO: Tipos de datos");
            Console.WriteLine("=========================================");
            Console.WriteLine();

            // Declaración de variables con distintos tipos de datos
            int age = 25;                 // Entero
            double height = 1.75;         // Decimal
            bool is_student = true;       // Booleano
            string name = "Ana";          // Texto
            char grade = 'A';             // Carácter

            // Impresión de cada variable con un mensaje descriptivo
            Console.WriteLine("La edad es: " + age);
            Console.WriteLine("La altura es: " + height);
            Console.WriteLine("¿Es estudiante?: " + is_student);
            Console.WriteLine("El nombre es: " + name);
            Console.WriteLine("La calificación es: " + grade);

            Console.WriteLine();
            Console.WriteLine("Fin del Reto: Tipos de datos.");
        }
    }
}
