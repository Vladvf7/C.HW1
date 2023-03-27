// Семинар №1 - Домашнее задание №1:
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.Write("Введите число а: ");
// int a = int.Parse(Console.ReadLine()!);

// System.Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine()!);

// if(a > b)
// {
//     System.Console.WriteLine("max = " + a);
// }
// else
// {
//     System.Console.WriteLine("max = " + b);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число c: ");
// int c = int.Parse(Console.ReadLine()!);

// if(a > b && a > c)
// {
//     System.Console.WriteLine($"Max {a}");
// }
// else if(b > a && b > c)
// {
//     System.Console.WriteLine($"Max = {b}");
// }
// else{
//     System.Console.WriteLine($"Max = {c}");
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine()!);

// if(a % 2 == 0)
// {
//     System.Console.WriteLine("Число четное ");
// }
// else
// {
//     System.Console.WriteLine("Чило не является четным");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5  -> 2, 4
// 8  -> 2, 4, 6, 8

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);

int num = 1;

while(num <= a)
{
    if(num % 2 == 0)
    {
        System.Console.Write(num + " ");
        }
        num = num + 1;
}
