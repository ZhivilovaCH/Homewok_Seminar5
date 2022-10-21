// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


int[] GetArray(int size, int minValue, int maxValue)
{

    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write($"i={i} {array[i]}, ");

    }
}

int GetMinus(int[] array)
{
    int max;
    int min;
    int count = 0;

    max = array.Max();
    min = array.Min();
    if (max > 0 && min > 0) count = max - min;

    else count = max + min;

    Console.WriteLine($"Max= {max} " + " | " + $"Min= {min}");
    return count;
}

int[] arr = GetArray(4, -100, 100);
Console.Clear();
PrintArray(arr);
Console.WriteLine();
int res = GetMinus(arr);
Console.WriteLine($"Pазница между максимальным и минимальным элементами массива = {res}");