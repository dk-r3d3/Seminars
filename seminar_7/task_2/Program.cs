// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

bool FindNumber(int[,] collection, int N)
{
    bool flag = false;
    foreach (var item in collection)
    {
        if (item == N)
        {
            flag = true;
        }
    }
    return flag;
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [4, 3];
FillArray(array);
PrintArray(array);
if (FindNumber(array, N))
{
    System.Console.WriteLine($"Число {N} есть в массиве");
}
else
    System.Console.WriteLine($"Числа {N} в массиве нет");