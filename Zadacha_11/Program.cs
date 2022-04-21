// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27

Console.Clear();
Console.Write("Введите число  ");
string d = Console.ReadLine();
int a = Convert.ToInt32(d);
int i = 1;
while (a > i)
{
    int c = i * i;
    Console.Write($" {c},");
    i = i + 1;    
}
int b = a * a;
Console.Write($" {b}.");
