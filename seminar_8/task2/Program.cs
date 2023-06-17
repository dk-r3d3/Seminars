// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
        for (int j = 0; j < collection.GetLength(1); j++)
            collection[i,j] = new Random().Next(0,10);
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
        {
            for (int j = 0; j < collection.GetLength(1); j++)
            {
                Console.Write($"{collection[i,j],1}  ");
            }
            System.Console.WriteLine();
        }
}

void FindSumm(int[,] collection, int[] summarray)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            summarray[i] += collection[i, j];
        }
    }
}

string FindMinSummString(int[] summarray)
{
    int min = 0;
    for (int i = 0; i < summarray.Length; i++)
    {
        if (summarray[i] < summarray[min])
        {
            min = i;
        }
    }
    return $"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {min + 1} строка";
}
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
int[] summarray = new int[rows];
FillArray(array);
PrintArray(array);
FindSumm(array, summarray);
System.Console.WriteLine(FindMinSummString(summarray));