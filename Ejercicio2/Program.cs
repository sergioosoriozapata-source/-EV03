using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("  EJERCICIO 2: Operadores aritméticos");
            Console.WriteLine("              y de asignación");
            Console.WriteLine("=========================================");
            Console.WriteLine();

            int a = 10;
            int b = 3;

            Console.WriteLine("Operando con a = " + a + " y b = " + b);
            Console.WriteLine();

            // Operadores aritméticos básicos
            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            int division = a / b;
            int modulo = a % b;

            Console.WriteLine("--- Operadores aritméticos ---");
            Console.WriteLine("Suma:            " + a + " + " + b + " = " + suma);
            Console.WriteLine("Resta:           " + a + " - " + b + " = " + resta);
            Console.WriteLine("Multiplicación:  " + a + " * " + b + " = " + multiplicacion);
            Console.WriteLine("División entera: " + a + " / " + b + " = " + division);
            Console.WriteLine("Módulo (resto):  " + a + " % " + b + " = " + modulo);
            Console.WriteLine();

            // Operadores de asignación compuestos
            int acumulador = 20;
            Console.WriteLine("--- Operadores de asignación ---");
            Console.WriteLine("Valor inicial del acumulador: " + acumulador);

            acumulador += 5;
            Console.WriteLine("acumulador += 5  -> " + acumulador);

            acumulador -= 3;
            Console.WriteLine("acumulador -= 3  -> " + acumulador);

            acumulador *= 2;
            Console.WriteLine("acumulador *= 2  -> " + acumulador);

            acumulador /= 4;
            Console.WriteLine("acumulador /= 4  -> " + acumulador);

            acumulador %= 4;
            Console.WriteLine("acumulador %= 4  -> " + acumulador);
            Console.WriteLine();

            // Cálculo básico: promedio de tres notas
            int nota1 = 85, nota2 = 90, nota3 = 78;
            int promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("--- Cálculo básico: promedio de notas ---");
            Console.WriteLine("Notas: " + nota1 + ", " + nota2 + ", " + nota3);
            Console.WriteLine("Promedio: (" + nota1 + " + " + nota2 + " + " + nota3 + ") / 3 = " + promedio);

            Console.WriteLine();
            Console.WriteLine("Fin del Ejercicio 2.");
        }
    }
}
