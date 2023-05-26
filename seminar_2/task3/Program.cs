// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите цифру от 1 до 7:  ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 6 && day >=1)
    System.Console.WriteLine("Нет");
else if (day == 6 || day == 7)
    System.Console.WriteLine("Да");
else
    System.Console.WriteLine("Такого дня недели нет");
