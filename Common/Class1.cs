




namespace Common;
public static class Helper
{
public static int[] fillingArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = int.Parse(Console.ReadLine());
    }

    return array;
}

public static void PrintResult(int[] arrayResult)
{
    int count = 0;

    for (int i = 0; i < arrayResult.Length; i++)
    {
        if (arrayResult[i] > 0)
        {
            count++;
        }
    }

    if (count <= 4 && count != 1 && count != 0)
    {
        Console.Write($"Вы ввели {count} числа больше нуля");
    }
    if (count == 1)
    {
        Console.Write($"Вы ввели {count} число больше нуля");
    }

    if (count > 4 || count == 0)
    {
        Console.Write($"Вы ввели {count} чисел больше нуля");
    }

}

public static double[] SolutionEquation(double b1, double k1, double b2, double k2)

{
    double x = 0;
    double y = 0;

    x = (b1 - b2) / (k2 - k1);
    y = ((-k1 * b2) + (k2 * b1)) / (k2 - k1);

    double[] array = new double[] { x, y };

    return array;

}


public static void PrintResult(double[] arrayResult)

{

    for (int i = 0; i < arrayResult.Length; i++)

    {
        if (i == 0)
        {
            Console.WriteLine($"X равно: {arrayResult[i]}");
        }
        else
        {
            Console.WriteLine($"Y равно: {arrayResult[i]}");
        }

    }

}
}
