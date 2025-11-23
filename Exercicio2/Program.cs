/* == Pedir para um usuario digitar um numero e mostrar se o numero é Pai ou Impar == */
/* Meu objetivo é atraves de exercicos construir uma logica de programação e algoritmo solida,
atraves de exercicios que vão dificultando ao longo do tempo. */

//Pedindo para usuario digitar um numero
Console.WriteLine("Digite um numero: ");

//Salvando este numero em uma variavel chamada numero
int numero = int.Parse(Console.ReadLine());

// Verificando com if se o resto da divisão por 2 do numero digitado for 0
if (numero % 2 == 0)
{
    //Se o numero for Par ele mostrara na tela a mensagem
    Console.WriteLine($"O numero {numero} é Par");
}
else
{
    //Se o resto da divisão não for 0 ele ira exibir esta mensagem na tela
    Console.WriteLine($"O numero {numero} é Impar");
}