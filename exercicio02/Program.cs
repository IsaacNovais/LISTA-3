int v2, v3;
Console.Write("Digite o primeiro valor: ");
v2 = int.Parse(Console.ReadLine());
do
{
    Console.Write("Digite o segundo valor (maior que o primeiro): ");
    v3 = int.Parse(Console.ReadLine());
} while (v3 <= v2);
Console.Write($"Os valores retornados são: {v2} e {v3}.");
Console.ReadLine();