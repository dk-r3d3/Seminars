// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] matrix = new int[,]
{
    {0, 0, 0, 0},
    {0, 0, 0, 0},
    {0, 0, 0, 0},
    {0, 0, 0, 0}
};
// int[,] matrix = new int[,]
// {
//     {0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0},
//     {0, 0, 0, 0, 0, 0}
// };

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

    int rowUp = 0; // с нулевой строки
    int rowDown = matrix.GetLength(0) - 1; // с крайней строки

    int columLeft = 0; // крайний левый столбец
    int columRight = matrix.GetLength(1); // крайний правый столбец
    
    for (int i = 0; i < columRight; i++) // строка ВЕРХНЯЯ
    {
        matrix[rowUp, i] = count;
        count++;
    }
    rowUp++;
    columRight--;

    for (int j = rowUp; j <= columRight; j++) // столбец ПРАВЫЙ
    {
        matrix[j, columRight] = count;
        count++;
    }
    columRight--;

    for (int k = columRight; k >= 0; k--) // строка НИЖНЯЯ
    {
        matrix[rowDown, k] = count;
        count++;
    }
    rowDown--;

    for (int n = rowDown; n > 0; n--) // столбец ЛЕВЫЙ
    {
        matrix[n, columLeft] = count;
        count++;
    }
    columLeft++;



    for (int m = rowUp; m <= columRight; m++) // строка 2
    {
        matrix[rowUp, m] = count;
        count++;
    }
    rowUp++;

    for (int n = rowUp; n <= rowDown; n++) // столбец 4
    {
        matrix[n, columRight] = count;
        count++;
    }
    columRight--;

    for (int o = columRight; o > 0; o--) // строка 4
    {
        matrix[rowDown, o] = count;
        count++;
    }
    rowDown--;
}

PrintArray(matrix);
FillMatrix(0, 0);
System.Console.WriteLine();
PrintArray(matrix);