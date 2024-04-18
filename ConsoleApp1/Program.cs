/*int x;
//float y;
char c;*/

/*int idade;
string nome;
nome = Console.ReadLine();
idade = int.Parse(Console.ReadLine());

//Console.Write(nome);

Console.WriteLine(nome + ", seja bem vindo!\nVoce tem " + idade + "anos");
//Console.WriteLine("Voce tem " + idade + "anos");
Console.ReadKey();*/

// ler o ano de nascimento e dizer a idade
/*int idade;
int ano;

Console.WriteLine("Digite seu ano de Nascimento: ");
ano = int.Parse(Console.ReadLine());

idade = 2024 - ano;
Console.WriteLine($"Voce tem {idade} anos.");
Console.WriteLine("Voce tem " + idade + " anos.");

Console.ReadLine();*/

//conta basica de matematica com as 4 operações matematicas


// variavel double para receber valores quebrados
double num1;
double num2;

Console.WriteLine("Digite o valor 1: ");
num1 = Double.Parse(Console.ReadLine()); //double.parse é para fazer o armazenamento  como double na variavel
Console.WriteLine("Digite o valor 2: ");
num2 = Double.Parse(Console.ReadLine());

// Adição
double soma = num1 + num2;
Console.WriteLine("Soma: " + soma);

        // Subtração
double subtracao = num1 - num2;
Console.WriteLine("Subtração: " + subtracao);

        // Multiplicação
double multiplicacao = num1 * num2;
Console.WriteLine("Multiplicação: " + multiplicacao);

// Divisão
if (num2 == 0)
{
    Console.WriteLine("Impossivel dividir por zero! ");
}
else
{
    if (num2 < 0)
    {
        Console.WriteLine("Numero negativo");
    }
    else
    {
        double divisao = num1 / num2;
        Console.WriteLine("Divisão: " + divisao);
    }
}
Console.ReadLine();