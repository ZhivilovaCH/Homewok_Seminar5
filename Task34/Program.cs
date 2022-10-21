// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.


int[] CountEqual = new int[8];

void PrintArray(int[] array)
{
    int temp = array.Length;
    for (int i = 0; i < temp; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
}

int PrintNumbers(int[] array)
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
Console.WriteLine();
PrintArray(CountEqual);
Console.WriteLine();
int res = PrintNumbers(CountEqual);
Console.WriteLine($"Чётных чисел в массиве = {res}");
