// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int FindSumElements(int M, int N)
{
    if (N <= M) return N;
    return FindSumElements(M, N - 1) + N;
}
System.Console.WriteLine("Задайте значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задайте значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindSumElements(M, N));