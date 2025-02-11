using System;

class Ejercicio1 {
    static void Main() {
        double[] calificaciones = new double[6];
        double suma = 0;
        
        for (int i = 0; i < 5; i++) {
            Console.Write($"Ingrese la calificación {i + 1}: ");
            calificaciones[i] = double.Parse(Console.ReadLine());
            suma += calificaciones[i];
        }

        // Calcular el promedio
        calificaciones[5] = suma / 5;

        // Mostrar calificaciones y promedio
        Console.WriteLine("\nCalificaciones ingresadas:");
        for (int i = 0; i < 5; i++) {
            Console.WriteLine($"Parcial {i + 1}: {calificaciones[i]}");
        }
        Console.WriteLine($"Promedio: {calificaciones[5]}");
    }
}
