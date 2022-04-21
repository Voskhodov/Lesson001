// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double xa = 3;
double ya = 6;
double za = 8;
double xb = 2;
double yb = 1;
double zb = -7;
double s = (xa-xb) * (xa-xb) + (ya-yb) * (ya-yb) + (za-zb) * (za-zb);
s = Math.Sqrt(s);
Console.Write("Растояние между точками = ");
Console.Write("{0:f}", s);