
int fib1 = 1, fib2 = 1, fib3;
Console.WriteLine($"Os primeiros trinta valores da série de Fibonacci são:");
Console.WriteLine(fib1);
Console.WriteLine(fib2);
for (int i = 3; i <= 30; i++)
{
    fib3 = fib1 + fib2;
    Console.WriteLine(fib3);
    fib1 = fib2;
    fib2 = fib3;
}
Console.ReadLine();
