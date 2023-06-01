// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


void FillArray(int N, int[] collection)
{
    int num = 0;
    for (int i=N.ToString().Length-1; i>=0; i--)
    {
        num = N % 10;
        N = N / 10;
        collection[i] = num;
    }
}

int Sum(int[] collection)
{
    int res = 0;
    foreach (int i in collection)
    {
        res += i;
    }
    return res;
}

Console.Clear();
System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N.ToString().Length];
FillArray(N, array);
System.Console.WriteLine(Sum(array));
