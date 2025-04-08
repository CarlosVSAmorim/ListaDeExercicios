Console.Write("Temperatura em Celsius: ");
double celsius = double.Parse(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2}");