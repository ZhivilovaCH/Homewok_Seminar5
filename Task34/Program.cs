// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.

int[] CountEqual = new int[8];

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
}

int CountNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }

    }

    return count;
}

Console.Clear();
PrintArray(CountEqual);
Console.WriteLine();
int res = CountNumbers(CountEqual);
Console.WriteLine($"Чётных чисел в массиве = {res}");