using System;

class Ejercicio4 {
    static void Main() {
        double[,] promedios = new double[10, 3];

        for(int i = 0; i < 10; i++) {
            Console.WriteLine($"\nIngrese el promedio del alumno {i + 1} del grupo A:");
            promedios[i, 0] = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el promedio del alumno {i + 1} del grupo B:");
            promedios[i, 1] = double.Parse(Console.ReadLine());

          // elijo el mayor de los 2 promedios
            if(promedios[i,0]>=promedios[i,1])
            promedios[i,2] = promedios[i,0];
            else{
                promedios[i,2] = promedios[i,1];
            }
        }

        Console.WriteLine("\nPromedios más altos:");
        for (int i = 0; i < 10; i++) {
            Console.WriteLine($"Alumno {i + 1}: {promedios[i, 2]}");
        }
    }
}
