
int fatorial;
do
{
    Console.Write("Digite um número inteiro positivo: ");
    fatorial = int.Parse(Console.ReadLine());
} while (fatorial <= 0);

for (int contadorFatorial = fatorial - 1; contadorFatorial >= 1; contadorFatorial--)
{
   fatorial *= contadorFatorial;
}

Console.WriteLine($"O fatorial é: {fatorial}");
Console.WriteLine("Aperte qualquer tecla para continuar...");
Console.ReadKey();
