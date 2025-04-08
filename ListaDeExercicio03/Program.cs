Console.Write("Quilometragem inicial: ");
double kmInicial = double.Parse(Console.ReadLine());

Console.Write("Quilometragem final: ");
double kmFinal = double.Parse(Console.ReadLine());

Console.Write("Combustível consumido (litros): ");
double combustivel = double.Parse(Console.ReadLine());

double consumo = (kmFinal - kmInicial) / combustivel;
Console.WriteLine($"Consumo médio: {consumo:F2} km/l");