// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Например:
// [3 7 22 2 78] -> 76


Console.Clear();
Console.WriteLine();

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);

double[] array = FillArray(size);
Console.WriteLine($"[{string.Join(", ", array)}] -> {(Math.Round(MaxNumber(array) - MinNumber(array), 3))}");

double[] FillArray(int size) // Функция заполнения массива.
{
    Random random = new Random();
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble(), 3);
    }
    return array;
}

double MinNumber(double[] array) // Функция нахождения минимального числа в массиве. 
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double MaxNumber(double[] array) // Функция нахождения максимального числа в массиве. 
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
