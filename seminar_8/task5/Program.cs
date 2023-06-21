// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// пока не решил

int[,] matrix = new int[,]
{
    {0, 0, 0, 0},
    {0, 0, 0, 0},
    {0, 0, 0, 0},
    {0, 0, 0, 0}
};

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
        {
            for (int j = 0; j < collection.GetLength(1); j++)
            {
                Console.Write($"{collection[i,j],1}   ");
            }
            System.Console.WriteLine();
        }
}

void FillMatrix(int rows, int cols)
{
    int count = 1;
    int countrow = 0;
    int countcolumn = 0;
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    for (int i = 0; i < matrix.GetLength(1) - 1; i++) // строка 1
    {
        matrix[countrow, i] = count;
        count++;
    }
    countrow++;
    for (int j = 0; j < matrix.GetLength(0); j++) // столбец 4
    {
        matrix[j, (column - 1) - countcolumn] = count;
        count++;
    }
    for (int k = matrix.GetLength(1) - 2; k > 0 ; k--) // строка 4
    {
        matrix[row - countrow, k] = count;
        count++;
    }
    for (int n = matrix.GetLength(0) - 1; n > 0; n--) // столбец 1
    {
        matrix[n, countcolumn] = count;
        count++;
    }
    for (int m = 1; m <= matrix.GetLength(1) - 2; m++) // строка 2
    {
        matrix[countrow, m] = count;
        count++;
    }
    countrow++;
    for (int p = matrix.GetLength(0) - 2; p > 0; p--) // строка 3
    {
        matrix[countrow, p] = count;
        count++;
    }
}

PrintArray(matrix);
FillMatrix(0, 0);
System.Console.WriteLine();
PrintArray(matrix);