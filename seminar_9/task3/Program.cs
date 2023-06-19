// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int M, int N)
{
    int res = 0;
    if (M == 0)
    {
        res = N + 1;
    }
    else if (M > 0 && N == 0)
    {
        res = Akkerman(M - 1, 1);
    }
    else if (M > 0 && N >0)
        res = Akkerman(M - 1, Akkerman(M, N - 1));
    return res;
}

System.Console.WriteLine("Задайте значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задайте значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Akkerman(M, N));