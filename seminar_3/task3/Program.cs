// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string sqrInline (double N)
{
    int count = 1;
    int sqr;
    string result = "";

    while (count <= N)
    {
        sqr = count*count*count;
        result = result + sqr.ToString() + ", ";
        count++;
    }
    return result;
}

Console.Clear();
System.Console.Write("Введите число: ");
double N = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(sqrInline(N));