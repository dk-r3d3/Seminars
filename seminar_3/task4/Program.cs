// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

void FillArray1(int N, int[] collection)
{
    int сount = 1;
    for (int i=0; i<N; i++)
    {

        System.Console.Write($"Введите {сount}-ю координату первой точки: ");
        collection[i] = int.Parse(Console.ReadLine());
        сount++;
    }
}

void FillArray2(int N, int[] collection)
{
    int сount = 1;
    for (int i=0; i<N; i++)
    {

        System.Console.Write($"Введите {сount}-ю координату второй точки: ");
        collection[i] = int.Parse(Console.ReadLine());
        сount++;
    }
}

void DiffArray(int N, int[] collection_1, int[] collection_2, int[] collection_3)
{
    for (int i = 0; i<N; i++)
    {
        collection_3[i] = (collection_2[i] - collection_1[i])*(collection_2[i] - collection_1[i]);
    }
}

int SumArray(int N, int[] collection)
{
    int sum = 0;
    for (int i=0; i<N; i++)
    {
        sum += collection[i];
    }
    return sum;
}

double SqrtArray(int sum)
{
    double res = Math.Sqrt(sum);
    return res;
}

System.Console.WriteLine("Введите размерность пространства: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array_1 = new int[N];
int[] array_2 = new int[N];
int[] array_diff = new int[N];

FillArray1(N, array_1);
FillArray2(N, array_2);
DiffArray(N, array_1, array_2, array_diff);
System.Console.WriteLine($"Расстояние между двумя точками в {N} - мерном пространстве составит - {SqrtArray(SumArray(N, array_diff))}");