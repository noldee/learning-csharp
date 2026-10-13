using System;

namespace LearningCsharp.Fundamentos;

public class Ejercicios
{
    public static void Ejecutar()
    {
        Console.WriteLine("=== Calculadora Simple ===");

        // Pedir y validar el primer número
        Console.Write("Ingresa el primer número: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Error: eso no es un número válido");
            return;
        }

        // Pedir y validar el segundo número
        Console.Write("Ingresa el segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Error: eso no es un número válido");
            return;
        }

        // Pedir y validar la operación
        Console.Write("Ingresa la operación (+, -, *, /): ");
        string operacion = Console.ReadLine() ?? "";

        if (operacion.Length != 1)
        {
            Console.WriteLine("Error: debes ingresar un solo símbolo");
            return;
        }

        char simbolo = operacion[0];
        double resultado = 0;

        switch (simbolo)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: no se puede dividir entre cero");
                    return;
                }
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("Símbolo no válido");
                return;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }
}