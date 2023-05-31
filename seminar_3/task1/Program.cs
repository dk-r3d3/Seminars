// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void FillArray_1(int[] collection, int n)
{
    int res = 0;
    for (int i=0; i<=4; i++)
    {
        res = n % 10;
        n = n / 10;
        collection[i] = res;
    }
}

void FillArray_2(int[] collection, int n)
{
    int res = 0;
    for (int j=n.ToString().Length-1; j>=0; j--)
    {
        res = n % 10;
        n = n / 10;
        collection[j] = res;
    }
}

int Diff(int[] collection_1, int[] collection_2)
{
    int count = 0;
    for(int r=0; r<collection_1.Length; r++)
    {
        if(collection_1[r]==collection_2[r]){
                    count ++;
                }
    }
    return count;
}

string Res(int count)
{
    if (count==5)
    {
        return "Yes";
    }
    else
        return "No";
}


System.Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());

int[] array_1 = new int[5];
int[] array_2 = new int[5];
FillArray_1(array_1, n);
foreach(int var in array_1)
{
    System.Console.WriteLine(var);
}
FillArray_2(array_2, n);

System.Console.WriteLine(Res(Diff(array_1, array_2)));



