// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

// int FindQuarter(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     else if (x < 0 && y > 0) return 2;
//     else if (x < 0 && y < 0) return 3;
//     else if (x > 0 && y < 0) return 4;
//     System.Console.WriteLine("The point is in the line!");
//     return 0;
// }
// System.Console.Write("Input X:");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input Y:");
// int y = Convert.ToInt32(Console.ReadLine());
// int result = FindQuarter(x, y);
// System.Console.WriteLine($"The point is in the {result} quarter");



// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double FindDistance(double xa, double ya, double xb, double yb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2);
// }

// System.Console.Write("Input XA:");
// int xa = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input YA:");
// int ya = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input XB:");
// int xb = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input YB:");
// int yb = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(FindDistance(xa, ya, xb, yb));





// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// void SquareTable(int number)
// {
//     int current = 1;
//     while (number >= current)
//     {
//         System.Console.WriteLine($"{current} -> {current * current}");
//         current++;
//     }
// }
// System.Console.Write("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// SquareTable(num);




// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

void CordinateRange(int quarter)
{
    if(quarter == 1)
    {
        System.Console.WriteLine("x + y +");
    }
    else if(quarter == 2)
    {
        System.Console.WriteLine("x - y +");
    }
    else if(quarter == 3)
    {
        System.Console.WriteLine("x - y -");
    }
    else if(quarter == 4)
    {
        System.Console.WriteLine("x + y -");
    }
    else
    {
        System.Console.WriteLine("Inputed incorrect quarter");
    }
}
System.Console.Write("Input quarter:");
int num = Convert.ToInt32(Console.ReadLine());
CordinateRange(num);