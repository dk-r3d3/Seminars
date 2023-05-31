// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет,
// является ли оно палиндромом. Через строку нельзя решать само собой.

void FillArray_1(long[] collection, long n)
{
    long res = 0;
    long n_const = n;
    for (long i=0; i<=n_const.ToString().Length-1; i++)
    {
        res = n % 10;
        n = n / 10;
        collection[i] = res;
    }
}
void FillArray_2(long[] collection, long n)
{
    long res = 0;
    long n_const = n;
    for (long j=n_const.ToString().Length-1; j>=0; j--)
    {
        res = n % 10;
        n = n / 10;
        collection[j] = res;
    }
}

long Diff(long[] collection_1, long[] collection_2)
{
    long count = 0;
    for(long r=0; r<collection_1.Length; r++)
    {
        if(collection_1[r]==collection_2[r]){
                    count ++;
                }
    }
    return count;
}

string Res(long n, long count)
    {
        if (n.ToString().Length==count)
        {
            return "Полиндром";
        }
        else
            return "Не полиндром";
    }

System.Console.Write("Введите любое целое число: ");
long n = Convert.ToInt64(Console.ReadLine());

long[] array_1 = new long[n.ToString().Length];
long[] array_2 = new long[n.ToString().Length];
FillArray_1(array_1, n);
FillArray_2(array_2, n);
System.Console.WriteLine(Res(n, Diff(array_1, array_2)));