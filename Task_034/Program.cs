// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Например:
// [345, 897, 568, 234] -> 2


Console.Clear();
Console.WriteLine();

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = FillArray(size);
Console.WriteLine($"[{string.Join(", ", array)}] -> Количество чётных чисел = {EvenNumbers(array)}");

int[] FillArray(int size)  // Функция заполнения массива случайными числами.
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

int EvenNumbers(int[] array) // Функция определения чётных чисел в массиве.
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

