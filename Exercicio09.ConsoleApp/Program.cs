/* 
9. Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
    a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
O fatorial de um número inteiro positivo (representado por n!) é o resultado da multiplicação desse número por todos os seus antecessores até chegar ao 1.
*/
Console.WriteLine("-------------------------------------------");
Console.WriteLine("Calculando o Fatorial de um Número");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

Console.WriteLine("Digite um Número: ");
int numero = Convert.ToInt32(Console.ReadLine());
int fatorial = 1;

for (int iterador = numero; iterador > 1; iterador--)
{
    fatorial *= iterador;
    Console.Write($"{iterador} X ");
}
Console.WriteLine($"1 = {fatorial}");

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Pressione Enter para sair...");
Console.ReadLine();