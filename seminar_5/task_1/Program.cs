// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] collection, int N)
{
    for (int i = 0; i < N; i++)
    {
        collection[i] = new Random().Next(100, 999);
    }
}
int Find(int[] collection)
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
System.Console.Write("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray(array, N);
System.Console.Write("[");
foreach (var item in array)
{
    System.Console.Write(item + " ");
}
System.Console.Write("] -> ");
System.Console.Write(Find(array));

