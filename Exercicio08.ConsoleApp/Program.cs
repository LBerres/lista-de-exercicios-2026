/* 
8. Faça um Algoritmo para Receber um Número Qualquer e Informar na Tela se é Par ou Ímpar.
Formula (número % 2 == 0) => Par
                                  > Utiliza-se o operador de módulo % (que retorna o resto da divisão).
Formula (número % 2 == 1) => Ímpar
*/



Console.WriteLine("-------------------------------------------");
Console.WriteLine("Verificando se um Número é Par ou Ímpar");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

Console.WriteLine("Digite um Número: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"{numero} % 2 = {numero % 2}");
    Console.WriteLine($"Então o Número {numero} é Par.");
}
else
{
    Console.WriteLine($"{numero} % 2 = {numero % 2}");
    Console.WriteLine($"Então o Número {numero} é Ímpar.");
}

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Pressione Enter para sair...");
Console.ReadLine();
