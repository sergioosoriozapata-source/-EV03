using System;

namespace RetoOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("  RETO: Operadores (área y perímetro)");
            Console.WriteLine("=========================================");
            Console.WriteLine();

            // 1. Declarar dos variables enteras
            int width = 7;
            int height = 5;

            // 2. Calcular el área del rectángulo (ancho × alto)
            int area = width * height;

            // 3. Calcular el perímetro del rectángulo (2 × ancho + 2 × alto)
            int perimeter = 2 * width + 2 * height;

            Console.WriteLine("Valores iniciales -> width: " + width + ", height: " + height +
                              ", area: " + area + ", perimeter: " + perimeter);

            // 4. Incrementar width en 3 unidades usando un operador de asignación compuesto
            width += 3;

            // 5. Decrementar height en 2 unidades usando un operador de asignación compuesto
            height -= 2;

            // 6. Recalcular área y perímetro con las nuevas dimensiones
            area = width * height;
            perimeter = 2 * width + 2 * height;

            // 7. Mostrar por consola los valores finales
            Console.WriteLine("Valores finales   -> width: " + width + ", height: " + height +
                              ", area: " + area + ", perimeter: " + perimeter);

            Console.WriteLine();
            Console.WriteLine("Fin del Reto: Operadores.");
        }
    }
}
