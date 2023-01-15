// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int functionAkkerman(int oneNumber, int twoNumber)
{
    if (oneNumber == 0) return (twoNumber + 1);
    else if (oneNumber > 0 && twoNumber == 0)
    {
        return (functionAkkerman(oneNumber - 1, 1));
    }
    return (functionAkkerman(oneNumber - 1, functionAkkerman(oneNumber, twoNumber - 1)));
}

Console.WriteLine(functionAkkerman(m, n));