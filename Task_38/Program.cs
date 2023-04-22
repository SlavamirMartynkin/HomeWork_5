//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
//[3,21 7,04 22,93 -2,71 78,24] -> 80,95

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
double[] RandomArray(int length, int minValue, int maxValue) 
{
    Random rnd =new Random();
    maxValue++;
    double[] array = new double [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rnd.Next(minValue, maxValue) + rnd.NextDouble(), 2);
    }
    return array;
}
double[] BubbleSort(double [] array) 
{
    double temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}
void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]}   ");
    }
    System.Console.WriteLine();
}
double Difference(double[] array)
{
    double difference;
    difference = array[array.Length - 1] - array[0];
    return difference;
}

int length = ReadInt("Введите длину массива: ");
int minValue = ReadInt("Введите нижний порог: ");
int maxValue = ReadInt("Введите верхний порог: ");
double[] arr = RandomArray(length, minValue, maxValue);
PrintArray(arr);
BubbleSort(arr);
PrintArray(arr);
Console.WriteLine($"Разница максимального и минимального элементов массива: {Difference(arr)}.");