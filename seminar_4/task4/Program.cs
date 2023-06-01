// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001 -> 4
// Не дорешал

void Diff(double N, int[] collection)
{
    string str = N.ToString();
    if (str.IndexOf(',') > -1)
    {
        string[] words = str.Split(',');
        for (int i = 0; i<2; i++)
        {
            collection[i] = Convert.ToInt32(words[i]);
        }
    }
    else
        {
            collection[0] = Convert.ToInt32(Math.Floor(N));
        }
    
}

int CountNumbers(int[] collection)
{
    int count1 = 0;
    int count2 = 0;
    int res = 0;
    for (int i=0; i<collection[0].ToString().Length; i++)
    {
        count1++;
    }
    for (int j=0; j<collection[1].ToString().Length; j++)
    {
        count2++;
    }
    res = count1 + count2;
    return res;
}

int LenArray(double N)
{
    if (N % 1 != 0)
    {
        return 2;
    }
    else
    {
        return 1;
    }
}

System.Console.Write("Введите число: ");
double N = Convert.ToDouble(Console.ReadLine());

int[] numbers = new int[LenArray(N)];
Diff(N, numbers);

System.Console.WriteLine(CountNumbers(numbers));