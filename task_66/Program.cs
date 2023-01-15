// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int start, int end)
{
    if (start == end) return 0;

    return ((start + end) * (end - start + 1) / 2);
}

Console.WriteLine(SumNumbers(m, n));