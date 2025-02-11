using System;

class Ejercicio6 {
    static void Main() {
        int pares = 0, impares = 0;

        for (int i = 0; i < 20; i++) {
            Console.Write($"Ingrese el número {i + 1}: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                pares++;
            else
                impares++;
        }

        Console.WriteLine($"\nTotal de números pares: {pares}");
        Console.WriteLine($"Total de números impares: {impares}");
    }
}
