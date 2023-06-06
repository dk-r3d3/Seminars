// Задача НЕГАФИБОНАЧЧИ необязательная. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.

// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

void FillArray(int[] array1, int[] array2, int num)
{
    if (num > 2)
    {
        array1[0] = 0;
        array1[1] = 1;
        array2[0] = 1;
        for (int i = 2; i < num; i++)
        {
            array1[i] = array1[i - 1] + array1[i - 2];
        }
        for (int i = 1; i < num - 1; i += 1)
        {
            array2[i] = array1[i + 1];
        }
        for (int i = 1; i < num - 1; i += 2)
        {
            array2[i] *= -1;
        }
    }
}

void FillArrayRes(int[] array2, int[] array1, int[] array3, int num)
{
    if (num > 2)
    {
        int count = 0;
        for (int i = 0; i < array2.Length; i++)
        {
            array3[i] = array2[i];
        }
        for (int i = 0; i < array1.Length; i++)
        {
            array3[array2.Length + count] = array1[i];
            count++;
        }
    }
    else if (num == 2)
    {
        array3[0] = 1;
        array3[1] = 0;
        array3[2] = 1;
    }
    else if (num == 1)
    {
        array3[0] = 0;
    }
}

void PrintArray(int[] array3)
{
    foreach (var item in array3)
    {
        Console.Write($"{item} ");
    }
}
try
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] array1 = new int[num];
    int[] array2 = new int[num - 1];
    int[] array3 = new int[num * 2 - 1];
    FillArray(array1, array2, num);
    Array.Reverse(array2);
    FillArrayRes(array2, array1, array3, num);
    PrintArray(array3);
}
catch (System.Exception)
{
    System.Console.WriteLine("Error");
}