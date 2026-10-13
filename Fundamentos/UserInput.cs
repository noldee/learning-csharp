using System;

namespace LearningCsharp.Fundamentos;

public class UserInput
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese un número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese otro número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("El resultadoes: " + (num1 + num2));
    }
}
