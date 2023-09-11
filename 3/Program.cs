// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число");
string nume = Console.ReadLine();
int day = int.Parse(nume);


bool WeekEnd(int day)
{
    if (day > 5)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool WeekDay(int day)
{
    if (day > 0 && day <= 7)
    {
        return true;
    }
    System.Console.WriteLine("Неверное число");
    return false;
}
if (WeekDay(day))
{
    if (WeekEnd(day))
    {
        System.Console.WriteLine("Выходной");
    }
    else
    {
        System.Console.WriteLine("Рабочий день");
    }
}
