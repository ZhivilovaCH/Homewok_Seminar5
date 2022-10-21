// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

Console.Clear();
Console.WriteLine("Введите массив через пробел: ");
string input = Console.ReadLine();
int[] numArray = GetArrayFromString(input);
Console.WriteLine("Введите искомое число: ");
int n = int.Parse(Console.ReadLine()!);

if (CheckArray(numArray, n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");

}

Console.Clear();
Console.WriteLine(" Hello ");
int[] CountEqual = new int[8];
int count = 0;
for (int i = 0; i < CountEqual.Length; i++)
{
    CountEqual[i] = new Random().Next(-100, 100);
    if (CountEqual[i] % 2 == 1)
    {
        count += CountEqual[i];

    }
    //Console.WriteLine ("count " + count);
    Console.Write(CountEqual[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Cуммa элементов, стоящих на нечётных позициях   = " + count);