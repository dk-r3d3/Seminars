// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
                Console.Write($"{collection[i,j],2}    ");
            }
            System.Console.WriteLine();
        }
}

void PrintAverage(int[,] collection, double[] res)
{
    int count = 0;
    double summ = 0;
    while (count < collection.GetLength(1))
    {
        for (int i = 0; i < collection.GetLength(0); i++)
        {
            summ += collection[i,count];
        }
    res[count] = Math.Round(summ / collection.GetLength(1), 2);
    summ = 0;
    count++;
    }
}

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
double[] resarray = new double[cols];
FillArray(array);
PrintArray(array);
PrintAverage(array, resarray);
System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
foreach (double item in resarray)
{
    System.Console.Write(item + ": ");
}