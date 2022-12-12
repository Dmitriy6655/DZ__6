// Задача 41 Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.

using static Common.Helper;

Console.Write("Введите количество чисел: ");
int quantity = int.Parse(Console.ReadLine());

int[] array = new int[quantity];
int[] arrayResult = fillingArray(array);

PrintResult(arrayResult);
