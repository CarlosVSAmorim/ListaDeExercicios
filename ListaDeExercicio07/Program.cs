Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());
bool ehPrimo = true;

if (numero <= 1) ehPrimo = false;
else {
    for (int i = 2; i <= Math.Sqrt(numero); i++) {
        if (numero % i == 0) {
            ehPrimo = false;
            break;
        }
    }
}

Console.WriteLine(ehPrimo ? "Número primo" : "Não é primo");