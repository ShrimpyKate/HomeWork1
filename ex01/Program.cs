//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 200;
int b = 111;
int max = b;
int min = a;
if (a > b) 
  {
  max = a; min = b;
  }
else
  {
  min = a; max = b;
  }
  
Console.Write( "max =");
Console.WriteLine( max );
Console.Write( "min =");
Console.WriteLine (min);

