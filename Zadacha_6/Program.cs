// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int numberA = 918;
int numberB = numberA % 10;
int numberC = numberA / 100;

Console.Write ($"{numberC}{numberB}");