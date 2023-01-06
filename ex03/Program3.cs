// Напишите программу, которая на вход принимает число и выдаёт,является ли число чётным (делится ли оно на два без остатка)


int N = Convert.ToInt32 (Console.ReadLine());

if ( N % 2 == 0 ) Console.WriteLine( $"число является четным - {true}");
else Console.WriteLine($"число является четным - {false}");

