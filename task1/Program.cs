// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int M = new Random().Next(1, 11);
int N = new Random().Next(11, 21);
System.Console.WriteLine("Старт: " + M);
System.Console.WriteLine("Стоп: " + N);

PrintNaturalNumbers(M, N);

void PrintNaturalNumbers(int start, int stop)
{
    if (start > stop)
    {
        return;
    }
    Console.Write(start + " ");
    start++;
    PrintNaturalNumbers(start, stop);
}