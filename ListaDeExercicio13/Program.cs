Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int fatorial = 1;
string passos = "";

for (int i = numero; i >= 1; i--) {
    fatorial *= i;
    passos += i + (i > 1 ? " x " : "");
}

Console.WriteLine($"{numero}! = {passos} = {fatorial}");