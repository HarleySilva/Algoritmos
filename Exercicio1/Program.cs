/* == Pedir para um usuario digitar dois numero e mostrar o resultado da soma entre eles == */
/* Meu objetivo é atraves de exercicos construir uma logica de programação e algoritmo solida,
atraves de exercicios que vão dificultando ao longo do tempo. */

//Pedindo para o usuario digita um numero
Console.WriteLine("Digite um numero: ");

//Salvando o numero digitado na variavel numero1
int numero1 = int.Parse(Console.ReadLine());

//Pedindo para o usuario digitar outro numero
Console.WriteLine("Digite outro numero: ");

//Salvando o numero digitado na variavel numero2
int numero2 = int.Parse(Console.ReadLine());

//Criando uma variavel que armazena o resultado da soma entre numero1 e numero2
int resultado = numero1 + numero2;

Console.WriteLine($"O resultado da soma: {numero1} + {numero2} = {resultado}");