using System;

class Ejercicio2 {
    static void Main() {
        double[] grupoA = new double[5];
        double[] grupoB = new double[5];
        double[] mayores = new double[5];

        Console.WriteLine("Ingrese los promedios del grupo A:");
        for (int i = 0; i < 5; i++) {
            grupoA[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingrese los promedios del grupo B:");
        for (int i = 0; i < 5; i++) {
            grupoB[i] = double.Parse(Console.ReadLine());
        }

        // Determinar el promedio mayor en cada posición
        for (int i = 0; i < 5; i++) {
            if(grupoA[i] >= grupoB[i])
            mayores[i] = grupoA[i];
            else
                mayores[i] = grupoB[i];
            
        }
      
      //uso un foreach para recorrer todo el arreglo
        Console.WriteLine("\nPromedios más altos:");
        foreach (double mayor in mayores) { 
            Console.WriteLine(mayor);
        }
    }
}
