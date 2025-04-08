Console.Write("Digite um número limite: ");
int limite = int.Parse(Console.ReadLine());

int a = 0, b = 1;
Console.Write("Fibonacci: ");

while (a <= limite) {
    Console.Write($"{a} ");
    int temp = a + b;
    a = b;
    b = temp;
}
Console.WriteLine();