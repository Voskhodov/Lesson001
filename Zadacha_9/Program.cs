// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
int numberA = 23432;
int numberB = numberA % 10;
int numberC = numberA /10 % 10;
int numberE = numberA /1000 % 10;
int numberF = numberA /10000 % 10;

if (numberB == numberF && numberC == numberE)
{
    Console.Write ($"Число {numberA} является палиндромом");
}
else
{
Console.Write ($"Число {numberA} является не палиндромом");
}