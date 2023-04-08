//Calcule a parcela do FGTS sobre o salário de um funcionário (8%).

double salario;
double fgts;

Console.WriteLine("--- Calculo do FGTS ---\n");

Console.Write("Digite o salário do funcionário: ");
salario = Convert.ToDouble(Console.ReadLine()!);

fgts = salario * 0.08;

Console.WriteLine($"\nParcela do FGTS: R$ {fgts:F2}");
