using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("  EJERCICIO 3: Interpolación de strings");
            Console.WriteLine("=========================================");
            Console.WriteLine();

            string nombre = "Carlos";
            int edad = 32;
            string ciudad = "Madrid";

            // Interpolación básica usando el símbolo $
            string presentacion = $"Hola, me llamo {nombre}, tengo {edad} años y vivo en {ciudad}.";
            Console.WriteLine(presentacion);
            Console.WriteLine();

            // Expresiones dentro de las llaves
            int a = 5;
            int b = 7;
            Console.WriteLine("--- Expresiones dentro de las llaves ---");
            Console.WriteLine($"La suma de {a} y {b} es {a + b}");
            Console.WriteLine($"El doble de {a} es {a * 2}");
            Console.WriteLine();

            // Formatos específicos aplicados a los valores
            decimal precio = 123.45m;
            DateTime fecha = new DateTime(2023, 10, 15);

            Console.WriteLine("--- Aplicando formatos ---");
            Console.WriteLine($"Precio (moneda): {precio:C}");
            Console.WriteLine($"Fecha: {fecha:dd/MM/yyyy}");
            Console.WriteLine($"Valor con 2 decimales: {precio:F2}");
            Console.WriteLine();

            // Alineación de columnas
            Console.WriteLine("--- Alineación de columnas ---");
            Console.WriteLine($"{"Nombre",-15}{"Edad",5}");
            Console.WriteLine(new string('-', 20));
            Console.WriteLine($"{"Ana",-15}{25,5}");
            Console.WriteLine($"{"Juan Carlos",-15}{42,5}");
            Console.WriteLine($"{"Beatriz",-15}{31,5}");

            Console.WriteLine();
            Console.WriteLine("Fin del Ejercicio 3.");
        }
    }
}
