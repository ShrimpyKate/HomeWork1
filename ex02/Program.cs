// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 13;
int b = 11;
int c = 77;

int max = a;

if ( b > max ) max = b;
if (c > max ) max = c;

Console.Write($"max = {max}");


