// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int a = 12;
int i = 1;
while (a > i)
{
    int c = i % 2;
    if (c == 0 )
    { 
        Console.Write($" {i},");
        
    }
    i = i + 1;
}
int b = a % 2;
if (b == 0 )
    { 
        Console.Write($" {a}.");
        
    }