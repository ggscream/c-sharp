// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine ("Введите первое число: ");
double x = Convert.ToDouble(Console.ReadLine ());

Console.WriteLine ("Введите второе число: ");
double y = Convert.ToDouble(Console.ReadLine ());

if (y > x)
{
    double max = y;
    double min = x;
    Console.WriteLine($"max = {max}, min = {min}");
}

else
{
    double max = x;
    double min = y;
    Console.WriteLine($"max = {max}, min = {min}");
}