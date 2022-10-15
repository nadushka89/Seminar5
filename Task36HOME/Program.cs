/*Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
//инициализация массива рандомные числами от -10 до 10 длиной length
int[] InitArray(int length)
{
    int[] resultArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(-10, 11);
    }
    return resultArray;
}
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
//получение суммы чисел на нечетных индексах
int GetSummOfPoint(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            summ += array[i];
    }
    return summ;
}
int length = GetNumber("Введите размерность массива");
int[] arr = InitArray(length);
PrintArray(arr);
int positionPoint = GetSummOfPoint(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {positionPoint}");