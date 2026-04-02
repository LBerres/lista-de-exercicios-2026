// 1. Crie um Programa para Calcular o Volume de uma Caixa Retangular
// Multiplique a largura, altura e comprimento (Fórmula: V = L x A x C)
// Base Para o Cálculo: 50 cm (comprimento) x 30 cm (largura) x 20 cm (altura).

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculando o Volume de uma Caixa Retangular");
Console.WriteLine("-------------------------------------------");

Console.Write("Digite o comprimento da caixa (em cm): ");
double comprimento = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-------------------------------------------");

Console.Write("Digite a largura da caixa (em cm): ");
double largura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-------------------------------------------");

Console.Write("Digite a altura da caixa (em cm): ");
double altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-------------------------------------------");

double volume = comprimento * largura * altura; // V = L x A x C

Console.WriteLine($"O Volume da Caixa Retangular é: {volume:F2} cm³"); // F = Floating-point format, 2 casas decimais

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Pressione Enter para sair...");
Console.ReadLine();