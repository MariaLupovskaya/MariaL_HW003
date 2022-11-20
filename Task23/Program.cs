// Задача 23.
// Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число");
string N = Console.ReadLine();
int N1 = int.Parse(N);
int x = 1;
while (x <= N1)
{
    double i = Math.Pow(x,3);
    Console.WriteLine(i);
    x++;
}