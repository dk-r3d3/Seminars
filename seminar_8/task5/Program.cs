// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// пока не решил

// int[,] matrix = new int[,]
// {
//     {0, 0, 0, 0},
//     {0, 0, 0, 0},
//     {0, 0, 0, 0},
//     {0, 0, 0, 0}
// };

// void PrintArray(int[,] collection)
// {
//     for (int i = 0; i < collection.GetLength(0); i++)
//         {
//             for (int j = 0; j < collection.GetLength(1); j++)
//             {
//                 Console.Write($"{collection[i,j],1}  ");
//             }
//             System.Console.WriteLine();
//         }
// }

// void FillMatrix(int row, int col)
// {
//     if (matrix[row, col] == 0)
//     {
//         matrix[row, col] = 0;
//         FillMatrix(row - 1, col);
//         FillMatrix(row, col - 1);
//         FillMatrix(row + 1, col);
//         FillMatrix(row, col + 1);
//     }
// }


// FillMatrix(4, 4);
// PrintArray(matrix);