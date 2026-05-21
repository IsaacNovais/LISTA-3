char sexo;
do
{
    Console.Write("Digite o sexo (M/F): ");
    sexo = char.Parse(Console.ReadLine().ToUpper());
} while (sexo != 'M' && sexo != 'F');
Console.Write($"O sexo retornado é: {sexo}.");
Console.ReadLine();