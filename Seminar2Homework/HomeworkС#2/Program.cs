// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456-> 5
// 782-> 8
// 918-> 1
/*
// Функция для нахождение 2 цифры из трёхзначного числа
int SeredinaTrexZnach(int num)
{
    // Сначала находим остаток деления от 100
    // а потом делим на 10
    int result = (num % 100) / 10;
    // Возвращаем результат
    return result;
}
//Просим пользователя ввести 3-х значное число
Console.WriteLine("Введите трёхзанчное число: ");
// заносим его  в переменную а
int a = Convert.ToInt32(Console.ReadLine());
// Делаем проверку если число 3-х значное то....
if (a > 99 && a < 1000)
{
    //Вызываем функцию SeredinaTrexZnach
    int number = SeredinaTrexZnach(a);
    // и выводим результат на экран
    Console.WriteLine(number);
}
// иначе
else
{
    // Выводим предупреждение, что введено не 3-х значное число
    Console.WriteLine("упс, кажется вы ввели не трёхзанчное число!!!!");
}
*/

// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
// Функция для нахождения третьей цифры в 3-х значном числе
void NumberNomer3()
{
    // Создаём через рандом случайное число от 1 до 999
    int num = new Random().Next(1, 10000);
    // и выводим его на консоль
    Console.WriteLine("Случайное число = " + num);
    // Если число 3-х значное то......
    if (num > 99 && num < 1000)
    {
        // Нахотим третью цифру путём нахождения деления 
        // от остатка на 100, а потом на 10 
        int NumNom3 = (num % 100) % 10;
        // и выводим его на консоль
        Console.WriteLine("Третья цифра это - " + NumNom3);
    }
    // Если число имеет больше трёх знаков то ....
    else if (num > 1000)
    {
        // То сначала делим это цисло на 10
        // До дех пор пока оно не станет трёхзначным
        while (num > 1000)
        {
            num = num / 10;
        }
        // и только потом
        // Нахотим третью цифру путём нахождения деления 
        // от остатка на 100, а потом на 10 
        int NumNom3 = (num % 100) % 10;
        // и выводим его на консоль
        Console.WriteLine("Третья цифра это - " + NumNom3);
    }
    //Иначе
    else
    {
        Console.WriteLine("третьей цифры нет ");
    }
}
// Вызываем функцию NumberNomer3
NumberNomer3();
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Функция которя проверяет, является ли этот день выходным
void BydniIVihadnie(int num)
{
    // Делаем проверку если введено число 
    //  от 1 до 5 то....
    if (num <= 5 && num >= 1)
    {
        // Значит это будний день и пишем да
        Console.WriteLine("Да - это будний день");
    }
    // иначе если введено число 6 или 7
    else if (num == 6 || num == 7)
    {
        // Значит это выходной день и пишем нет
        Console.WriteLine("Нет - это выходной день");
    }
    else
    {
        // Значит такого дня недели нет
        Console.WriteLine(num + " Вы серьёзно,такого дня недели нет!!!!");
    }
}
//Просим пользователя ввести цифру, обозначающую день недели
Console.WriteLine("Введите цифру, обозначающую день недели: ");
// заносим его в переменную а
int a = Convert.ToInt32(Console.ReadLine());
BydniIVihadnie(a);

