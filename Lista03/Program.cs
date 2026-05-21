
int v1;
do
{
    Console.Write("Digite um valor maior que zero: ");
    v1 = int.Parse(Console.ReadLine());
} while (v1 <= 0);
Console.Write($"O valor retornado é: {v1}.");
Console.ReadLine();