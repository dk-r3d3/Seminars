// Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, которая принимает на вход целое число любой разрядности 
// и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

System.Console.Write("Введите целое число: ");

long num = Convert.ToInt64(Console.ReadLine());
long res = 0;

if (num.ToString().Length >= 4)
    {
        while (num > 1000)
        {
            num = num / 10;
            res = num % 10;
        };
    System.Console.WriteLine(res);
    }
else
    {
        System.Console.WriteLine("нет");
    };