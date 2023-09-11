//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
string nume1 = Console.ReadLine();
int num1 = int.Parse(nume1);

if (num1 < 100 || num1 > 999)
{
    Console.WriteLine($"Неверное число {num1}");
}
else
{
    int num2 = num1 % 100;
    int num3 = num2 / 10;
    System.Console.WriteLine($"Второе число {num3}");
}