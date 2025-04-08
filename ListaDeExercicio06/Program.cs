Console.Write("Nota 1: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Peso 1: ");
double peso1 = double.Parse(Console.ReadLine());

Console.Write("Nota 2: ");
double nota2 = double.Parse(Console.ReadLine());

Console.Write("Peso 2: ");
double peso2 = double.Parse(Console.ReadLine());

double mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);
Console.WriteLine($"Média ponderada: {mediaPonderada:F2}");