using System;

class Ejercicio3 {
    static void Main() {
        double[,] calificaciones = new double[5, 4];

        for (int i = 0; i < 5; i++) {
            double suma = 0;
            Console.WriteLine($"\nIngrese las 3 calificaciones del alumno {i + 1}:");
            for (int j = 0; j < 3; j++) {
                calificaciones[i, j] = double.Parse(Console.ReadLine());
                suma += calificaciones[i, j]; // sumo las calificaciones
            }
            calificaciones[i, 3] = suma / 3; // Guardar el promedio
        }
      
        //imprimo toda la información
        Console.WriteLine("\nCalificaciones y promedios:");
        for (int i = 0; i < 5; i++) {
            Console.Write($"Alumno {i + 1}: ");
            for (int j = 0; j < 4; j++) {
                Console.Write($"{calificaciones[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
