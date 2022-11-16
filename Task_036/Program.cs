// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Например:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();
Console.WriteLine();

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное число массива: ");
int min = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное число массива: ");
int max = int.Parse(Console.ReadLine()!);
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
ElementOddPosition(numbers);

int result = ElementOddPosition(numbers);
Console.WriteLine($"Сумма элементов нечётных позиций = {result}");

int ElementOddPosition(int[] numbers) // Функция нахождения элементов на нечетных позициях.
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += numbers[i];
        }
    }
    return result;
}

void FillArrayRandomNumbers(int[] array) // Функция заполнения массива.
{
    for (int i = 0; i < array.Length; i++)
    {
        Random random = new Random();
        array[i] = random.Next(min, max);
    }
}

void PrintArray(int[] array) // Функция вывода массива на экран.
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine();
}