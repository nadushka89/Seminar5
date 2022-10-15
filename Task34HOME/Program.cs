/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] RandomArray()
{
    int[] array = new int[4];
    Random rnd = new Random();
    for (int i = 0; i < 4; i++)
        array[i] = rnd.Next(100, 1000);
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < 4; i++)
        Console.Write($"{array[i]} ");
}

int NumbEven(int[] array)
{
    int counter = 0;
    for (int i = 0; i < 4; i++)
        if ((array[i] % 2) == 0)
            counter++;
    return counter;
}
int[] arr = RandomArray();
PrintArray(arr);
Console.WriteLine("");
int count = NumbEven(arr);
Console.WriteLine($"Количество четных чисел в массиве - {count} ");


