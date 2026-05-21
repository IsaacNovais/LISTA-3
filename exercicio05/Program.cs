
int v5;
do
{
    Console.WriteLine("Exibir a tabuada de um valor positivo digitado");
    Console.Write("Digite um valor positivo: ");
    v5 = int.Parse(Console.ReadLine());
} while (v5 <= 0);
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{v5} x {i} = {v5 * i}");
}
Console.ReadLine();