/*
    4 . Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário
    base e o total de vendas. A comissão é calculada com um percentual (informado pelo
    usuário) sobre o total de vendas.
*/

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculando Salário Total de um Vendedor");
Console.WriteLine("-------------------------------------------");

Console.WriteLine("Digite o Salário Base do Vendedor: ");
double salarioBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o Total de Vendas do Vendedor: ");
double totalVendas = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a Comissão (em percentual) sobre o Total de Vendas: ");
double percentualComissao = Convert.ToDouble(Console.ReadLine());

double comissao = totalVendas * (percentualComissao / 100); // Calculando a comissão
double ValorTotal = comissao + salarioBase; // Calculando o salário total

Console.WriteLine("O salário total do vendedor é: " + ValorTotal);

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Pressione Enter para sair...");
Console.ReadLine();
