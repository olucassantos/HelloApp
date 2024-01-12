// Imprime um texto na tela.
Console.WriteLine("Hello World!");

Console.WriteLine("Seja bem-vindo ao meu primeiro programa!");

// Criação de duas variáveis.
string nome;
int idade;

Console.WriteLine("Qual é o seu nome?");

// Lê o nome digitado pelo usuário e armazena na variável nome.
nome = Console.ReadLine();
Console.WriteLine("Prazer em conhecer" + nome + "!");

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Você tem " + idade + " anos de idade.");
