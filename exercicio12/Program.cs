char opcao;
do
{
    Console.Clear();
    int n1;
    do
    {
        Console.Write("Digite um valor menor que vinte e maior que zero: ");
        n1 = int.Parse(Console.ReadLine());
    } while (n1 <= 0 || n1 >= 20);

    double soma = 0;
    double maior = double.MinValue;
    double menor = double.MaxValue;
    double positivos = 0;
    double negativos = 0;

    for (int i = 1; i <= n1; i++)
    {
        double valor;
        Console.Write("Digite um valor qualquer: ");
        valor = double.Parse(Console.ReadLine());

        if (valor > 0)
        {
            positivos++;

        }
        else if (valor < 0)
        {
            negativos++;
        }

        soma += valor;

        if (valor > maior)
        {
            maior = valor;
        }
        else if (valor < menor)
        {
            menor = valor;
        }
    }
    Console.WriteLine($"O maior valor digitado é: {maior}");
    Console.WriteLine("Aperte qualquer tecla para continuar...");
    Console.ReadKey();
    Console.WriteLine($"O menor valor digitado é: {menor}");
    Console.WriteLine("Aperte qualquer tecla para continuar...");
    Console.ReadKey();
    Console.WriteLine($"A soma dos N valores digitados é: {soma}");
    Console.WriteLine("Aperte qualquer tecla para continuar...");
    Console.ReadKey();
    Console.WriteLine($"A média aritmética dos N valores digitados é: {soma / n1}");
    Console.WriteLine("Aperte qualquer tecla para continuar...");
    Console.ReadKey();
    Console.WriteLine($"A porcentagem dos valores positivos é: {(positivos / n1) * 100}%");
    Console.WriteLine("Aperte qualquer tecla para continuar...");
    Console.ReadKey();
    Console.WriteLine($"A porcentagem dos valores negativos é: {(negativos / n1) * 100}%");
    Console.WriteLine("Aperte qualquer tecla para continuar...");
    Console.ReadKey();

    Console.WriteLine("Informe se deseja continuar o programa? (S/N): ");
    opcao = char.Parse(Console.ReadLine().ToUpper());
} while (opcao != 'N'); 