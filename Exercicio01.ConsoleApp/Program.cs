// 1. Crie um Programa para Calcular o Volume de uma Caixa Retangular
// Multiplique a largura, altura e comprimento (Fórmula: V = L x A x C)
// Base Para o Cálculo: 50 cm (comprimento) x 30 cm (largura) x 20 cm (altura).

double comprimento = 50; // em cm
double largura = 30; // em cm
double altura = 20; // em cm

double volume = comprimento * largura * altura; // V = L x A x C

Console.WriteLine($"O Volume da Caixa Retangular é: {volume:F2} cm³"); // F = Floating-point format, 2 casas decimais

Console.ReadLine();