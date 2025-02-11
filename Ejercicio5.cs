using System;

class Program {
    static void Main() {
        double totalIngresos = 0;
        double[] arreglo = new double[100];

        for (int i = 0; i < 100; i++) {
            Console.Write($"Ingrese la compra del cliente {i + 1}: ");
            arreglo[i] = double.Parse(Console.ReadLine());
            totalIngresos += arreglo[i];
        }

        Console.WriteLine($"\nTotal de ingresos del supermercado: {totalIngresos}");
    }
}
