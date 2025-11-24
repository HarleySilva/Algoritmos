/* == Pedir para um usuario digitar três numeros e mostrar qual deles é o maior == */
/* Meu objetivo é atraves de exercicos construir uma logica de programação e algoritmos solidos,
atraves de exercicios que vão dificultando ao longo do tempo. */

//Pedindo para o usuario digitar o primeiro numero
Console.WriteLine("Digite um numero: ");

//Salavando numero digitado na variavel chamada numero1
int numero1 = int.Parse(Console.ReadLine());

//Pedindo para o usuario digitar o segundo numero numero
Console.WriteLine("Digite o segundo numero: ");

//Salavando numero digitado na variavel chamada numero2
int numero2 = int.Parse(Console.ReadLine());

//Pedindo para o usuario digitar o terceiro numero
Console.WriteLine("Digite o terceiro numero: ");

//Salavando numero digitado na variavel chamada numero3
int numero3 = int.Parse(Console.ReadLine());

//Estrutura de decisão. Vendo qual numero é o maior e o mostrando na tela
if (numero1 > numero2)
{
    //Se o numero1 for maior exibira a mensagem abaixo
    Console.WriteLine($"O numero {numero1} é o maior");
}
else if (numero2 > numero3)
{
    //Se o numero2 for maior exibira a mensagem abaixo
    Console.WriteLine($"O numero {numero2} é o maior");
}
else
{
    //Se o numero3 for o maior exibira a mensagem abaixo
    Console.WriteLine($"O numero {numero3} é o maior");
}