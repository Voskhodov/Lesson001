﻿// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int a = 32679;
// int b;
if (a < 99)
    {
        Console.WriteLine ($"У числа {a} третьего знака нет.");
    }
    
while (a > 1000)
    {
        a = a / 10;
    }
Console.WriteLine (a % 10);