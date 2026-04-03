// 5. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno. (Formula: Média Ponderada = (Nota1 * Peso1 + Nota2 * Peso2) / (Peso1 + Peso2))

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculando Média Ponderada de Duas Provas");
Console.WriteLine("-------------------------------------------");

Console.WriteLine("Digite a Nota da Primeira Prova: ");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o Peso da Primeira Prova: ");
double peso1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("-------------------------------------------");

Console.WriteLine("Digite a Nota da Segunda Prova: ");
double nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o Peso da Segunda Prova: ");
double peso2 = Convert.ToDouble(Console.ReadLine());

double mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

Console.WriteLine("A Média Ponderada das Duas Provas é: " + mediaPonderada);

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Pressione Enter para sair...");
Console.ReadLine();