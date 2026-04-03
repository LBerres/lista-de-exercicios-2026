/*
7. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta.

A fórmula é IMC = peso / (altura) 2.

Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
    IMC em adultos Condição
        a. Abaixo de 18,5 = Abaixo do peso
        b. Entre 18,5 e 25 = Peso normal
        c. Entre 25 e 30 = Acima do peso
        d. Acima de 30 = Obeso
*/

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculando o Índice de Massa Corporal (IMC)");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

Console.WriteLine("Digite o peso (em kg): ");
double peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-------------------------------------------");

Console.WriteLine("Digite a altura (em metros): ");
double altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-------------------------------------------");

double imc = peso / (altura * altura);

if (imc < 18.5)
{
    Console.WriteLine($"IMC: {imc:F2} - Abaixo do peso");
}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine($"IMC: {imc:F2} - Peso normal");
}
else if (imc >= 25 && imc < 30)
{
    Console.WriteLine($"IMC: {imc:F2} - Acima do peso");
}
else
{
    Console.WriteLine($"IMC: {imc:F2} - Obeso");
}

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Pressione Enter para sair...");
Console.ReadLine();