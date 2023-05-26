// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int len = num.ToString().Length;
int res = 0;

if (len >= 3)
    {
        while (num > 1000)
        num = num / 10;
        res = num % 10;
    System.Console.WriteLine(res);
}
else
    System.Console.WriteLine("Третьей цифры нет");
