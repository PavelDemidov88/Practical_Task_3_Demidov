// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: " );
int Num = int.Parse(Console.ReadLine());

int a = Num/10000;
int b = Num%10;
int c = (Num%10000)/1000;
int d = (Num%100)/10;

if (a == b && c == d)
{
Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}