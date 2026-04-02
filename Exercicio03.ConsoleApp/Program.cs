// 3. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
// Multiplicamos a temperatura em ºC por 1,8 e somamos 32 ao resultado.

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Convertendo Temperatura de Celsius para Fahrenheit");
Console.WriteLine("-------------------------------------------");

Console.WriteLine("Digite a Temperatura em Celsius (ºC): ");
double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());

double temperaturaFahrenheit = (temperaturaCelsius * 1.8) + 32; // Fórmula: (ºC * 1,8) + 32

Console.WriteLine($"A Temperatura em Fahrenheit é: {temperaturaFahrenheit:F2} ºF"); // F = Floating-point format, 2 casas decimais

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Pressione Enter para sair...");

Console.ReadLine();
