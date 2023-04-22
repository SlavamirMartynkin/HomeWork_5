// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]} ");
    }
    System.Console.WriteLine();
}
int[] RandomArray(int length, int minValue = 100, int maxValue = 999) 
{
    Random rnd =new Random();
    int[] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}
int Even(int[] array)
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

int length = ReadInt("Введите длину массива: ");
int[] arr = RandomArray(length);
PrintArray(arr);
System.Console.WriteLine($"в этом массиве {Even(arr)} четных чисел(а)");
