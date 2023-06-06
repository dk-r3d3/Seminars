// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Введите значения переменных b1, k1, b2, k2: ");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

string Res(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        return "Прямые параллельны";
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);;
        double y = k1 * x + b1;
        x = Math.Round(x, 3);
        y = Math.Round(y, 3);
        return $"Точка пересечения: ({x};{y})";
    }
}
System.Console.WriteLine(Res(b1, k1, b2, k2));
