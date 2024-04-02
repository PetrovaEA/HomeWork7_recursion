//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(10, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}


void PrintReversedArray(int[] array, int lastIndex)
{
    if (lastIndex < 0)
    {
        return;
    }
    Console.Write(array[lastIndex] + " ");
    lastIndex--;
    PrintReversedArray(array, lastIndex);
}

int[] numbers = CreateArray(5);
System.Console.Write("Исходный массив: ");
PrintArray(numbers);
System.Console.Write("Элементы массива в обратном порядке: ");
PrintReversedArray(numbers, numbers.Length - 1);

