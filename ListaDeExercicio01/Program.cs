Console.Write("Comprimento: ");
double comprimento = double.Parse(Console.ReadLine());

Console.Write("Largura: ");
double largura = double.Parse(Console.ReadLine());

Console.Write("Altura: ");
double altura = double.Parse(Console.ReadLine());

double volume = comprimento * largura * altura;
Console.WriteLine($"Volume da caixa: {volume}");