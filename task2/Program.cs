//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

System.Console.WriteLine("Введите неотрицательное m");
int m = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите неотрицательное n");
int n = int.Parse(Console.ReadLine());

if (m < 0 || n < 0)
{
    System.Console.WriteLine("Одно из чисел отрицательное. Начните сначала.");
}
else
{
    System.Console.WriteLine(Ackerman(m, n));
}

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}