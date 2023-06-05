// Задача HARD STAT необязательная:
// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс,
// минимальный элемент и его индекс, среднее арифметическое всех элементов.
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

void FillArray(int[] collection, int N)
{
    for (int i = 0; i < N; i++)
    {
        collection[i] = new Random().Next(1, 99);
    }
}

void Sorted(int[] collection)
{
    for (int i = 1; i < collection.Length; i++)
    {
        for (int j = 0; j < collection.Length; j++)
        {
            if (collection[i] < collection[j])
            {
                (collection[j], collection[i]) = (collection[i], collection[j]);
            }
        }
    }
}

void FindMax(int[] collection, double[] last)
{
    int max_val = collection[0];
    int max_index = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > max_val)
        {
            max_val = collection[i];
            max_index = i;
        }
    }
    last[0] = max_val;
    last[1] = max_index;
}

void FindMin(int[] collection, double[] last)
{
    int min_val = collection[0];
    int min_index = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] < min_val)
        {
            min_val = collection[i];
            min_index = i;
        }
    }
    last[2] = min_val;
    last[3] = min_index;
}

void Average(int[] collection, double[] last)
{
    double sum = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        sum += collection[i];
    }
    last[4] = sum / collection.Length;
}

string Mediana(int[] collection)
{
    int average = collection.Length / 2;
    return $"Медианное значение в массиве - {collection[average]}.";
}

Console.Clear();
System.Console.WriteLine("Ввведите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
double[] array_res = new double[5];
FillArray(array, N);
FindMax(array, array_res);
FindMin(array, array_res);
Average(array, array_res);
System.Console.Write("В массиве - [");
foreach (var item in array)
{
    System.Console.Write(item + ", ");
}
System.Console.Write($"] минимальное число {array_res[2]} с индексом {array_res[3]}. ");
System.Console.Write($"Максимальное число {array_res[0]} с индексом {array_res[1]}. ");
System.Console.Write($"Среднее арифметическое чисел - {array_res[4]}. ");

Sorted(array);
System.Console.WriteLine(Mediana(array));