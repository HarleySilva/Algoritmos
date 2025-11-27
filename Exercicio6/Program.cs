/* == Pedir para um usuario digitar um numero e mostrar a tabuada completa com as respostas == */
/* Meu objetivo é atraves de exercicos construir uma logica de programação e algoritmo solida,
atraves de exercicios que vão dificultando ao longo do tempo. */

//Abrindo uma variavel para armazenar o valor digitado a variavel res serve para armazenar o valor do resultado
int numerotab, res;

//Pedindo para o usuario digitar um numero que iremos gerar sua tabuada
Console.Write("Escreva um numero e vou gerar sua tabuada: ");

//Armazenando o valor digitado pelo usuariio nesta variavel chamada numerotab
numerotab = int.Parse(Console.ReadLine());

/*Aqui crio um loop com for que rodara a linha de codigo até o i ser menor ou igual a 10
toda vez que o loop for repetido ele mostrara na tela o valor da conta, assim fazendo a tabuada de 0 a 10*/
for (int i = 0; i <= 10; i++)
{
    //Aqui armazeno a conta entre o numero digitado pelo usuario e pelo numero indicado no loop soma um a cada repetição
    res = numerotab * i;

    /*Aqui mostro na tela sempre que o loop for repetido, a conta mudara pois o numero i aumenta a cada loop e fazendo assim
    o resutado sendo diferete*/
    Console.WriteLine($"{numerotab} x {i} = {res}");
}