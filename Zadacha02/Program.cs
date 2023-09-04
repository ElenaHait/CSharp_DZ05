// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] arr = GenerateArray (10);
PrintArray(arr);
int sum = SumOddElemsOfArray(arr);
System.Console.WriteLine();
System.Console.Write("Сумма нечетных позиций массива = ");
System.Console.WriteLine(sum);



int SumOddElemsOfArray(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        result += array[i];
    }
    return result;
}

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}