// Напишите программу, которая выводит случайное 3-х значное число
// и удалает вторую цифру этого числа

// int CutNumber()
// {
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine("Number is - " + num);
//     int dec = num / 100;
//     int ed = num % 10;
//     int result = dec * 10 + ed;
//     return result;
// }

// int number = CutNumber();
// Console.WriteLine("Cut number is - " + number);


// void CutNumber()
// {
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine("Number is - " + num);
//     int dec = num / 100;
//     int ed = num % 10;
//     int result = dec * 10 + ed;
//     Console.WriteLine("Cut number is - " + result);
// }

// CutNumber();

// int Factorial(int num)
// {
//     int currenr = 1;
//     int fact = 1;
//     if (num > 0)
//     {
//         while (currenr <= num)
//         {
//             // fact =  fact * currenr;
//             fact *= currenr;
//             currenr++;
//         }
//         return fact;
//     }
//     else if (num == 0)
//     {
//         return fact;
//     }
//     else
//     {
//         Console.WriteLine("Факториал отрицательного числа не возможен! ");
//         return 0;
//     }
// }
// int result = Factorial(0) * Factorial(-2);
// Console.WriteLine("Your result is - " + result);

//Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру

// int Line()
// {
//     int num = new Random().Next(10, 100);
//     Console.WriteLine("Your number is: " + num);
//     int dec = num / 10;
//     int ed = num % 10;
//     if (dec > ed)
//     {
//         return dec;
//     }
//     else
//     {
//         return ed;
//     }
// }
// Console.WriteLine("Result - " + Line());


// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// void Crat(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         Console.WriteLine("Число кратно одновременно 7 и 23 ");
//     }
//     else
//     {
//         Console.WriteLine("Число не кратно одновременно 7 и 23 ");
//     }
// }
// while (true)
// {
//     Console.WriteLine("Enter the number: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     Crat(number);
// }

// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другово числа 

// void Square(int a, int b)
// {
//     if (a == b * b || b == a * a)
//     {
//         Console.WriteLine("Условие выполняется");
//     }
//     else
//     {
//         Console.WriteLine("Условие не выполняется");
//     }
// }

// Console.WriteLine("Enter the number1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Square(a, b);

//Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратное первому. Если число 2 
//не кратно число 1, то программа выводит остаток от деления.


int Square(int a, int b)
{
    if (b % a != 0)
    {
        int result = b % a;
        return result;
    }
    else
    {
        return 0;
    }

}

Console.WriteLine("Enter the number1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == 0 || b == 0)
{
    Console.WriteLine("На ноль делить нельзя");
}
else
{
    int result = Square(a, b);
    if (result == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Второе число не кратно первому. Остаток от деления: " + result);
    }
}
