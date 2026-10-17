using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("  EJERCICIO 1: Tipos de datos en C#");
            Console.WriteLine("=========================================");
            Console.WriteLine();

            // Constantes: valores que no cambian durante la ejecución
            const int DIAS_SEMANA = 7;
            const double GRAVEDAD = 9.81;
            const string NOMBRE_EMPRESA = "MiCompañía";

            // Tipos numéricos enteros
            int edad = 25;
            byte diaSemana = 7;
            short cantidadCorta = 32000;
            long poblacionMundial = 7_900_000_000L;
            uint cantidadPositiva = 100;

            // Tipos numéricos de punto flotante
            float altura = 1.75f;
            double pi = 3.14159265359;
            decimal precio = 19.99m;

            // Tipo booleano
            bool esMayorDeEdad = true;

            // Tipo carácter
            char letra = 'A';

            // Tipo cadena (string)
            string nombre = "Ana";

            // Impresión de cada variable con un mensaje descriptivo
            Console.WriteLine("--- Constantes ---");
            Console.WriteLine("Días de la semana (const int): " + DIAS_SEMANA);
            Console.WriteLine("Gravedad (const double): " + GRAVEDAD);
            Console.WriteLine("Empresa (const string): " + NOMBRE_EMPRESA);
            Console.WriteLine();

            Console.WriteLine("--- Tipos numéricos enteros ---");
            Console.WriteLine("Edad (int): " + edad);
            Console.WriteLine("Día de la semana (byte): " + diaSemana);
            Console.WriteLine("Cantidad corta (short): " + cantidadCorta);
            Console.WriteLine("Población mundial (long): " + poblacionMundial);
            Console.WriteLine("Cantidad positiva (uint): " + cantidadPositiva);
            Console.WriteLine();

            Console.WriteLine("--- Tipos numéricos de punto flotante ---");
            Console.WriteLine("Altura (float): " + altura);
            Console.WriteLine("Valor de PI (double): " + pi);
            Console.WriteLine("Precio (decimal): " + precio);
            Console.WriteLine();

            Console.WriteLine("--- Otros tipos ---");
            Console.WriteLine("¿Es mayor de edad? (bool): " + esMayorDeEdad);
            Console.WriteLine("Letra (char): " + letra);
            Console.WriteLine("Nombre (string): " + nombre);

            Console.WriteLine();
            Console.WriteLine("Fin del Ejercicio 1.");
        }
    }
}
