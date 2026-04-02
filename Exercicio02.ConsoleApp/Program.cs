/*
2. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.

    O programa deve solicitar ao usuário:
        a. A quilometragem inicial do veículo no início da viagem.
        b. A quilometragem final ao término da viagem.
        c. A quantidade de combustível consumida durante a viagem (em litros).
    (Fórmula: Consumo por Km = Litros Abastecidos / Quilometragem Rodados)
*/

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculando o Consumo de Combustível por Quilômetro");
Console.WriteLine("-------------------------------------------");

Console.Write("Digite a Quilometragem Inicial do Veículo (em km): ");
double quilometragemInicial = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-------------------------------------------");

Console.Write("Digite a Quilometragem Final do Veículo (em km): ");
double quilometragemFinal = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-------------------------------------------");

Console.Write("Digite a Quantidade de Combustível Consumido (em litros): ");
double litrosConsumidos = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-------------------------------------------");

double distanciaTotal = quilometragemFinal - quilometragemInicial;

if (litrosConsumidos > 0 && distanciaTotal > 0)
{
    double consumoPorKm = distanciaTotal / litrosConsumidos; // Consumo por Km = Quilometragem Rodados / Litros Abastecidos
    Console.WriteLine($"O Consumo de Combustível por Quilômetro é: {consumoPorKm:F4} km/l"); // F = Floating-point format, 4 casas decimais
}
else
{
    Console.WriteLine("Erro: A quantidade de combustível consumida e a distância percorrida devem ser maiores que zero.");
}

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Pressione Enter para sair...");
Console.ReadLine();