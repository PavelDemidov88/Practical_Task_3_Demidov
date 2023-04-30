// Задача 21 Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату Xa: ");
int xa = int.Parse(Console.ReadLine());
Console.Write("Введите координату Ya: ");
int ya = int.Parse(Console.ReadLine());
Console.Write("Введите координату Za: ");
int za = int.Parse(Console.ReadLine());

Console.Write("Введите координату Xb: ");
int xb = int.Parse(Console.ReadLine());
Console.Write("Введите координату Yb: ");
int yb = int.Parse(Console.ReadLine());
Console.Write("Введите координату Zb: ");
int zb = int.Parse(Console.ReadLine());

    int a,b,c;
    a = (xb-xa)*(xb-xa);
    b = (yb-ya)*(yb-ya);
    c = (zb-za)*(zb-za);
    var d = Math.Sqrt(a+b+c);
    Console.WriteLine("Расстояние между точек: " +d);

//double FinndDistance(double distance)
//{   
//    double square1 = (xb-xa)*(xb-xa);
//    double square2 = (yb-ya)*(yb-ya);
//    double square3 = (zb-za)*(zb-za);
//    double sum = square1+square2+square3;
//    result = Math.sqrt(sum);
//    return result;
//}
//Console.WriteLine("Расстояние между точек: " +d);