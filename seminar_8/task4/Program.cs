﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray(int[,,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
        for (int j = 0; j < collection.GetLength(1); j++)
            for (int k = 0; k < collection.GetLength(2); k++)
                {
                    collection[i,j,k] = new Random().Next(1,100);
                }
}

void PrintArray(int[,,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            for (int k = 0; k < collection.GetLength(2); k++)
            {
                Console.Write($"{collection[i,j,k], 1}({i}, {j}, {k})  ");
            }
            System.Console.WriteLine();
        }
    }
}
int[,,] array = new int [2, 2, 2];
FillArray(array);
PrintArray(array);