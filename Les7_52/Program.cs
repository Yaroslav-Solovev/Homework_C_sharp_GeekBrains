﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Функция вывода массива
int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
    for (var i = 0; i < result.GetLength(0); i++)
        for (var j = 0; j < result.GetLength(1); j++)
            result[i, j] = random.Next(1, 10);
    return result;
}

// Функция рандомного формирования массива из целых чисел
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Error");
}

Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Error");
}

int[,] array = CreateArrayWithRandomNumbers(m, n);

Console.Write($"\nЗаданный массив: \n");
PrintArray(array);

// Нахождение среднее арифметического каждого столбца массива
Console.Write($"\nCреднее арифметическое каждого столбца: ");
for (int i = 0; i < n; i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < m; j++)
    {
        arithmeticMean += array[j, i];
    }
    arithmeticMean = Math.Round(arithmeticMean / m, 1);
    Console.Write($"{arithmeticMean}; ");
}



// 1. Считывание из консоли с обработкой трайпарсов стоит вынести в отдельный метод, иначе код повторяется
// 2. Тут аналогично. Не забывайте использовать авто форматирование на Shift + Alt + F для виндоус и Shift + Command + F для мака, потому что формат кода сейчас не единообразный
// 3. Всё то же, что и выше. Поиск ср. ариф. — в отдельный метод