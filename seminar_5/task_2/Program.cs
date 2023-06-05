// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] collection, int N)
{
    for (int i = 0; i < N; i++)
    {
        collection[i] = new Random().Next(-99, 99);
    }
}
int Summ(int[] collection)
{
    int res = 0;
    for (int i = 1; i < collection.Length; i++)
    {
        if (i % 2 != 0)
        {
            res += collection[i];
        }
    }
    return res;
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
System.Console.Write(Summ(array));