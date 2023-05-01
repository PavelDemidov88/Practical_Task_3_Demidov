// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//int num = new Random().Next(1, 10);
Console.WriteLine("Введите число: " );
int num = int.Parse(Console.ReadLine());
int x = 1;
while (x <= num)
{
    int cube = x*x*x;
    Console.Write(" "+cube);
    x++; 
}
