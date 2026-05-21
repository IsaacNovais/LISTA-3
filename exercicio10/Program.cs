
int maior = int.MinValue, soma = 0;
for (int i = 1; i <= 10; i++)
{
    int valor;
    do
    {
        Console.Write($"Digite o {i}º valor positivo: ");
        valor = int.Parse(Console.ReadLine());
    } while (valor <= 0);
    soma += valor;
    if (valor > maior)
    {
        maior = valor;
    }
}
Console.WriteLine($"O maior valor digitado é: {maior}");
Console.WriteLine($"A soma dos valores digitados é: {soma}");
Console.WriteLine($"A média aritmética dos valores digitados é: {soma / 10.0}");
Console.ReadLine();