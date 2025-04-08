Console.Write("Raio da base: ");
double raio = double.Parse(Console.ReadLine());

Console.Write("Altura: ");
double altura = double.Parse(Console.ReadLine());

double volume = Math.PI * Math.Pow(raio, 2) * altura;
Console.WriteLine($"Volume do cilindro: {volume:F2}");