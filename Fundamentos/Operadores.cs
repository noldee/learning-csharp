namespace LearningCsharp.Operadores;

public static class Operadores
{
    public static void Ejecutar()
    {
        // Aritméticos
        Console.WriteLine(10 + 10);
        Console.WriteLine(10 - 10);
        Console.WriteLine(10 * 10);
        Console.WriteLine(10 / 10);
        Console.WriteLine(10 % 10);

        // Comparación
        Console.WriteLine(10 < 10);
        Console.WriteLine(10 > 10);
        Console.WriteLine(10 <= 10);
        Console.WriteLine(10 >= 10);
        Console.WriteLine(10 == 10);
        Console.WriteLine(10 != 10);

        // Lógicos
        Console.WriteLine(true && false);
        Console.WriteLine(true || false);
        Console.WriteLine(!true);

        // Asignación
        int n = 10;
        n += 5;
        Console.WriteLine(n);
        n -= 3;
        Console.WriteLine(n);
        n *= 2;
        Console.WriteLine(n);
        n /= 4;
        Console.WriteLine(n);
        n %= 4;
        Console.WriteLine(n);

        // Incremento / Decremento
        int a = 5;
        a++;
        Console.WriteLine(a);
        a--;
        Console.WriteLine(a);

        // Ternario
        Console.WriteLine(10 > 5 ? "mayor" : "menor");

        // Bitwise
        Console.WriteLine(5 & 3);
        Console.WriteLine(5 | 3);
        Console.WriteLine(5 ^ 3);
        Console.WriteLine(~5);
        Console.WriteLine(5 << 1);
        Console.WriteLine(5 >> 1);

        // Nulos
        string? nombre = null;
        Console.WriteLine(nombre ?? "sin nombre");
    }
}