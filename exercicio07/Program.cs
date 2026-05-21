 
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine($"Tabuada do {i}:");
    for (int intervalo = 1; intervalo <= 10; intervalo++)
    {
        Console.WriteLine($"{i} x {intervalo} = {i * intervalo}");
    }
    Console.WriteLine("Pressione uma tecla para exibir a próxima tabuada...");
    Console.ReadKey();
    Console.Clear();
}