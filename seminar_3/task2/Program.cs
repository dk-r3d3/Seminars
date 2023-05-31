// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Length(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
    return result;
}

System.Console.WriteLine("Введите координату x точки А");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки А");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки А");
double z1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите координату x точки В");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки В");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки В");
double z2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Расстояние между точками составит {Length(x1, y1, z1, x2, y2, z2)}");