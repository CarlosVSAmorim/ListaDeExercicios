Console.Write("Salário base: ");
double salarioBase = double.Parse(Console.ReadLine());

Console.Write("Total de vendas: ");
double vendas = double.Parse(Console.ReadLine());

Console.Write("Percentual de comissão (%): ");
double percentual = double.Parse(Console.ReadLine());

double comissao = vendas * (percentual / 100);
double salarioTotal = salarioBase + comissao;

Console.WriteLine($"Salário total: R$ {salarioTotal:F2}");