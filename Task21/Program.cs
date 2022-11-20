// Задача 21.
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координату X первой точки, Х1 =");
string str1 = Console.ReadLine();
Console.WriteLine("Введите координату Y первой точки, Y1 =");
string str2 = Console.ReadLine();
Console.WriteLine("Введите координату Z первой точки, Z1 =");
string str3 = Console.ReadLine();
Console.WriteLine("Введите координату X второй точки, Х2 =");
string str4 = Console.ReadLine();
Console.WriteLine("Введите координату Y второй точки, Y2 =");
string str5 = Console.ReadLine();
Console.WriteLine("Введите координату Z второй точки, Z2 =");
string str6 = Console.ReadLine();
int X1 = int.Parse(str1);
int Y1 = int.Parse(str2);
int Z1 = int.Parse(str3);
int X2 = int.Parse(str4);
int Y2 = int.Parse(str5);
int Z2 = int.Parse(str6);

double result = Math.Sqrt (Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));

Console.WriteLine(result);