Console.Write("Valor 1: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Valor 2: ");
int n2 = int.Parse(Console.ReadLine());

Console.Write("Valor 3: ");
int n3 = int.Parse(Console.ReadLine());

int[] numeros = { n1, n2, n3 };
Array.Sort(numeros);
Array.Reverse(numeros);

Console.WriteLine("Ordem decrescente: " + string.Join(", ", numeros));