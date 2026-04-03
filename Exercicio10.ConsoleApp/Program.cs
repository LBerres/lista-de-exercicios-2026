/*
10. Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo
os números múltiplos de 3 pela palavra "Fizz" e os múltiplos de 5 pela palavra "Buzz". Para
números que são múltiplos de ambos, use "FizzBuzz".
    a. Ex: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, ...
*/
Console.WriteLine("-------------------------------------------");
Console.WriteLine("Fizz! - Buzz! - FizzBuzz!");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();

Console.WriteLine("Aperte Enter para iniciar...");
Console.ReadLine();

for (int numero = 1; numero <= 100; numero++)
{
    if (numero % 3 == 0 && numero % 5 == 0)
    {
        Console.WriteLine("FizzBuzz, ");
    }
    else if (numero % 3 == 0)
    {
        Console.WriteLine("Fizz, ");
    }
    else if (numero % 5 == 0)
    {
        Console.WriteLine("Buzz, ");
    }
    else
    {
        Console.WriteLine($"{numero}, ");
    }
}

Console.WriteLine("\n-------------------------------------------");
Console.WriteLine("Pressione Enter para sair...");
Console.ReadLine();