// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ReadInt(string argument) 
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число!");
        Console.Write(argument);
    }
    return i;
}
int[] RandomArray(int length, int minValue = 1, int maxValue = 10) 
{
    Random rnd =new Random();
    int[] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]} ");
    }
    System.Console.WriteLine();
}
int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int length = ReadInt("Введите длину массива: ");
int[] arr = RandomArray(length);
PrintArray(arr);
System.Console.WriteLine($"Сумма элементов с нечетными индексами массива : {Sum(arr)}");
