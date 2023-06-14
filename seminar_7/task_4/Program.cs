// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры.
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

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

void OneArrayAndSorted(int[,] two, int[] one)
{
    int count = 0;
    for (int i = 0; i < two.GetLength(0); i++)
    {
        for (int j = 0; j < two.GetLength(1); j++)
        {
            one[count] = two[i, j];
            count++;
        }
        
    }
    for (int i = 1; i < one.Length; i++)
    {
        for (int j = 0; j < one.Length; j++)
        {
            if (one[i] < one[j])
            {
                (one[i], one[j]) = (one[j], one[i]);
            }
            
        }
    }
}

void ResArray(int[,] res, int[] one)
{
    int count = 0;
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = one[count];
            count++;
        }
    }
}

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
int[] onearray = new int[rows * cols];
int[,] resarray = new int [rows, cols];
FillArray(array);
PrintArray(array);
OneArrayAndSorted(array, onearray);
ResArray(resarray, onearray);
System.Console.WriteLine("");
PrintArray(resarray);