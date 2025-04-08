Console.Write("Valor de A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Valor de B: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Valor de C: ");
int c = int.Parse(Console.ReadLine());

if (a + b < c) {
    Console.WriteLine("A + B é menor que C");
} else {
    Console.WriteLine("A + B não é menor que C");
}