using System;

class Ejercicio7 {
    static void Main() {
        int[] numeros = new int[20];
        int[] cuadrados = new int[20];
        int[] cubos = new int[20];

        for (int i = 0; i < 20; i++) {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            cuadrados[i] = numeros[i] * numeros[i];
            cubos[i] = numeros[i] * numeros[i] * numeros[i];
        }

        Console.WriteLine("\nNúmero | Cuadrado | Cubo");
        for (int i = 0; i < 20; i++) {
            Console.WriteLine($"{numeros[i]} | {cuadrados[i]} | {cubos[i]}");
        }
    }
}
