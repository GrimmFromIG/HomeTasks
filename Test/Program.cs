using System;

class Program
{
    // Рекурсивний метод обчислення f(n) = n + 3 / n
    static double RecursiveFunction(double n)
    {
        if (n == 1) // Базовий випадок
            return 1 + 3 / 1;
        return n + 3 / n + RecursiveFunction(n - 1);
    }

    // Ітеративний метод обчислення f(n) = n + 3 / n
    static double IterativeFunction(double n)
    {
        double result = 0;
        for (double i = 1; i <= n; i++)
        {
            result += i + 3 / i;
        }
        return result;
    }

    static void Main(string[] args)
    {
        double n = 4; // Значення, для якого обчислюємо функцію

        // Виклик рекурсивного методу
        double recursiveResult = RecursiveFunction(n);
        Console.WriteLine($"Рекурсивний результат для f({n}) = {recursiveResult}");

        // Виклик ітеративного методу
        double iterativeResult = IterativeFunction(n);
        Console.WriteLine($"Ітеративний результат для f({n}) = {iterativeResult}");
    }
}