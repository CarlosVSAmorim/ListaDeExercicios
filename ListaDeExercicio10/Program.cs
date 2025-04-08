Console.Write("Peso (kg): ");
double peso = double.Parse(Console.ReadLine());

Console.Write("Altura (m): ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / Math.Pow(altura, 2);

Console.WriteLine($"IMC: {imc:F2}");

if (imc < 18.5) {
    Console.WriteLine("Abaixo do peso");
} else if (imc < 25) {
    Console.WriteLine("Peso normal");
} else if (imc < 30) {
    Console.WriteLine("Acima do peso");
} else {
    Console.WriteLine("Obeso");
}