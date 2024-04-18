Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

// Verificar se o número é par ou ímpar
if (numero % 2 == 0)
{
    Console.WriteLine("O número " + numero + " é par.");
}
else
{
    Console.WriteLine("O número " + numero + " é ímpar.");
}
Console.ReadLine();