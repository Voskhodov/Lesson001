// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int numberA = 6;
int numberB = numberA % 2;

if (numberB == 0) 
{
    Console.WriteLine ($"Число {numberA} чётное");
}
else
{
    Console.WriteLine ($"Число {numberA} нечётное");    
}