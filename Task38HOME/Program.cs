/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76*/
/*инициализация массива рандомные числами от 0 до 100 длиной length*/
int[] InitArray(int length)
{
    int[] resultArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(0, 101);
    }
    return resultArray;
}
//печать массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//получение числа с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
//получение max and min
(int, int) FindMaxAndMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    return (max, min);
}
int length = GetNumber("Введите размерность массива");
int[] arr = InitArray(length);
PrintArray(arr);
(int max, int min) = FindMaxAndMin(arr);
if (max != min)
    Console.WriteLine($"Разница между максимальным {max} и минимальным {min}  элементом массива {max - min}");