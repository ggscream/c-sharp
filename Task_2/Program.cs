// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine ("Введите первое число: ");
double x = Convert.ToDouble(Console.ReadLine ());

Console.WriteLine ("Введите второе число: ");
double y = Convert.ToDouble(Console.ReadLine ());

Console.WriteLine ("Введите третье число: ");
double z = Convert.ToDouble(Console.ReadLine ());

double max = x;

if (y > max)
{
    max = y;
}

if (z > max)
{
    max = z;
}

Console.WriteLine (max);