// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray(int N, int[] collection)
{
    int сount = 1;
    for (int i = 0; i < N; i++)
    {

        System.Console.Write($"Введите {сount}-е число: ");
        collection[i] = int.Parse(Console.ReadLine());
        сount++;
    }
}

int SummPositive(int[] collection)
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] >= 0)
        {
            count++;
        }
    }
    return count;
}
System.Console.Write("Сколько чисел желаете ввести? - ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
FillArray(N, array);
foreach (var item in array)
{
    System.Console.Write(item + " ");
}
System.Console.WriteLine($" -> {SummPositive(array)}");
