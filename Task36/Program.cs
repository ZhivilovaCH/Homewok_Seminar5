// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] CountOdd = new int[4];

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
        Console.Write($"i={i} {array[i]}, ");
    }
}

int GetSum(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            count += array[i];
        }
    }
    return count;
}

Console.Clear();
PrintArray(CountOdd);
Console.WriteLine();
int res = GetSum(CountOdd);
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях = {res}");
