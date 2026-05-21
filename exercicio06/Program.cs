int valor;
do
{
    Console.Write("Digite um valor positivo: ");
    valor = int.Parse(Console.ReadLine());
} while (valor <= 0);

int intervaloInicioEX6;
int intervaloFimEX6;
do
{
    Console.Write("Digite um valor positivo para o início do intervalo: ");
    intervaloInicioEX6 = int.Parse(Console.ReadLine());
} while (intervaloInicioEX6 <= 0); 
do
{
    Console.Clear();
    Console.Write("Digite o valor positivo para o fim do intervalo, sendo que deve ser maior o início do intervalo: ");
    intervaloFimEX6 = int.Parse(Console.ReadLine());
} while (intervaloFimEX6 <= 0 || intervaloFimEX6 <= intervaloInicioEX6); 
for (int i = intervaloFimEX6; i >= intervaloInicioEX6; i--) 
{
    int varTabuadaEX6 = valor * i;
    Console.WriteLine($"{i}: {varTabuadaEX6}");
}
Console.ReadLine();
