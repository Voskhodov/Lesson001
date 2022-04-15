// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int numberA = 7;
int numberB = 5;

if (numberB > numberA) 
{
    Console.WriteLine ($"Максимальное число {numberB}");
}
else
{
    Console.WriteLine ($"Максимальное число {numberA}");    
}