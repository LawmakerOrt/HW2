//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
string nume1 = Console.ReadLine();
int num1 = int.Parse(nume1);

if (num1 < 100)
{
    System.Console.WriteLine("Неверное значение");
}
while (num1 > 999)
{
    num1 /= 10;
}
if (num1 > 99 || num1 < 1000)
{
    num1 = num1 % 10;
}

System.Console.WriteLine(num1);
