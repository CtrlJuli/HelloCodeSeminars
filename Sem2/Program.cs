// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int DeleteSecondDigit(int num)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     int result = sot * 10 +ed;
//     return result;
// }

// int num = new Random(). Next(100, 999 + 1);
// System.Console.WriteLine(num);
// System.Console.WriteLine(DeleteSecondDigit(num));


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// void CheckSquare(int a, int b)
// {
//     if(a == b * b)
//     {
//         System.Console.WriteLine($"{a} квадрат {b}");
//     }
//     else if(b == a * a)
//     {
//         System.Console.WriteLine($"{b} квадрат {a}");
//     }
//     else if(a == b)
//     {
//         System.Console.WriteLine($"{a} и {b} равны!");
//     }
//     else
//     {
//         System.Console.WriteLine("Не является!");
//     }
// }
// System.Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// CheckSquare(num1, num2);


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// bool Multiple(int a)
// {
//     if(a % 7 == 0 && a % 23 == 0)
//     return true;
//     else return false;
// }
// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool result = Multiple(num);
// System.Console.WriteLine(result);


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число 
// кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void CheckMultiple(int a, int b)
{
    if(a % b ==0)
    {
        System.Console.WriteLine($"{a} кратно {b}");
    }
    else
    {
        System.Console.WriteLine($"{a} не кратно {b}, остаток {a % b}");
    }
}
System.Console.WriteLine("Input a, b ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
CheckMultiple(num1, num2);