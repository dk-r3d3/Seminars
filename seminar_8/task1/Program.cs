// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            Console.Write($"{collection[i,j],3}    ");
        System.Console.WriteLine();
        }
}

void SortedRows(int[,] collection)
{
    int count = 0;
    while (count < collection.GetLength(0))
    {
        for (int i = 1; i < collection.GetLength(1); i++)
        {
            for (int j = 0; j < collection.GetLength(1); j++)
            {
                if (collection[count, j] < collection[count, i])
                {
                    (collection[count, j], collection[count, i]) = (collection[count, i], collection[count, j]);
                }
            }
        }
        count++;
    }
    
}

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
SortedRows(array);
PrintArray(array);