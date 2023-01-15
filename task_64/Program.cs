// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n = Convert.ToInt32(Console.ReadLine());

string PrintNumber(int start, int end)
{
    if (end == start) return end.ToString();

    return (start + ", " + PrintNumber(start - 1, end));
}

Console.WriteLine(PrintNumber(n, 1));