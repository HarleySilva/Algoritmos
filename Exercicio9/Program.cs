/* == Pedir para um usuario digitar um numero e mostrar a soma de 1 até o numero digitado == */
/* Meu objetivo é atraves de exercicos construir uma logica de programação e algoritmo solida,
atraves de exercicios que vão dificultando ao longo do tempo. */

// Declaranto a varialvel onde vamos armazenar o numero digitado pelo usuario
int num;

// Perguntando para o usuario o numero que ele deseja
Console.Write("Escreva um numero: ");

// Armazenando na varial
num = int.Parse(Console.ReadLine());

// Declarando a varialvel que ira somar os numeros no loop
int soma = 0;

// Loop de repetição, ele repete a linha de codigo até o numero que o usuario digitou
for (int i = 1; i <= num; i++)
{
    // Sempre que o loop for rodado ira somar 1 nesta variavel até que chege no resultado
    soma = soma+i;
}

// Mostando na tela o resulta da de 1 até o valor digitado pelo usuario
Console.WriteLine($"A some 1 até {num} é: {soma}");