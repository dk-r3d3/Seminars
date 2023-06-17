// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void Composition(int[,] array1, int[,] array2, int[,] array3)
{
    int row = array1.GetLength(0) - 1;
    int col = array2.GetLength(1) - 1;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int r = 0;
            int c = 0;
            array3[i, j] = 0;
            while (c <= col)
            {
                array3[i, j] += array1[i, c] * array2[r, j];
                r++;
                c++;
            }
            
        }
        
    }
}

System.Console.WriteLine("Введите количество строк");
int rows1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols1 = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int [rows1, cols1];
FillArray(array1);
System.Console.WriteLine("Введите количество строк");
int rows2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols2 = Convert.ToInt32(Console.ReadLine());
int[,] array2 = new int [rows2, cols2];
FillArray(array2);

int[,] composition = new int [rows1, cols2];
try
{
    Composition(array1, array2, composition);
    PrintArray(array1);
    System.Console.WriteLine();
    PrintArray(array2);
    System.Console.WriteLine();
    PrintArray(composition);
}
catch
{
    System.Console.WriteLine(
        "Вы ввели матрицы, которые нельзя перемножить, количество строк первой матрицы должно равняться количеству столбцов второй."
    );
}