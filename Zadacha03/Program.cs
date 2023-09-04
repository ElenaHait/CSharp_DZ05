// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


System.Console.WriteLine("Введите длину массива: ");
int length = int.Parse(System.Console.ReadLine());
double[] arr = GenerateArray(length);
PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine("Разница Min и Max = ");
double difference = (DiffMinMax(arr));
System.Console.WriteLine(string.Format("{0:f4}", difference));

double[] GenerateArray(int length)
{
    double[] result = new double[length];
    for (int i = 0; i < result.Length; i++)
    {
       System.Console.WriteLine("Введите элементы: ");
       result[i] = double.Parse(System.Console.ReadLine());
    }
    return result;
}

void PrintArray(double[] array)
{
    foreach (double i in array)
    {
        Console.Write($"{i} ");
    }
}

double DiffMinMax(double[] arr)
{
    double minElem = arr[0];
    double maxElem = arr[0];
    double result;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElem) maxElem = arr[i];
        if (arr[i] < minElem) minElem = arr[i];
    }
    result = maxElem - minElem;
    return result;
}