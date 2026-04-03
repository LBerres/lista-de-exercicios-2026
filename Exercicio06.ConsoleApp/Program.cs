// 6. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Verificando se a soma de A + B é menor que C");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("Digite o valor de A: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor de C: ");
double c = Convert.ToDouble(Console.ReadLine());

if (a + b < c)
{
    Console.WriteLine($"A Soma de A({a}) + B({b}) = {a + b}, é Menor que C({c}).");
}
else if (a + b == c)
{
    Console.WriteLine($"A Soma de A({a}) + B({b}) = {a + b}, é Igual a C({c}).");
}
else
{
    Console.WriteLine($"A Soma de A({a}) + B({b}) = {a + b}, Não é Menor que C({c}).");
}

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Pressione Enter para sair...");
Console.ReadLine();
