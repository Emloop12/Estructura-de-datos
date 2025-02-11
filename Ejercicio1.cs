using System;

class Ejercicio1 {
    static void Main() {
        double[] calificaciones = new double[6];
        
        for (int i = 0; i < 5; i++) {
            Console.Write("Ingrese la calificación {i + 1}: ");
            calificaciones[i] = double.Parse(Console.ReadLine());
        }

        // Calcular el promedio
        calificaciones[5] = (calificaciones[0] + calificaciones[1] + calificaciones[2] + calificaciones[3] + calificaciones[4]) / 5;

        // Mostrar calificaciones y promedio
        Console.WriteLine("\nCalificaciones ingresadas:");
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Parcial {i + 1}: {calificaciones[i]}");
        }
        Console.WriteLine("Promedio: {calificaciones[5]}");
    }
}
