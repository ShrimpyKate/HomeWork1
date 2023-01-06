//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 88;
int b = 78;
int max = b;
int min = a;
if (a > b) max = a;
if (a < b) min = a;
if (b < a) min = b;
if (b > a) max = b;

Console.Write( "max =");
Console.WriteLine( max );
Console.Write( "min =");
Console.WriteLine (min);

