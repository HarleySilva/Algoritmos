/* == Pedir para um usuario digitar um valor em celcius e mostrar o resultado em fahrenheit == */
/* Meu objetivo é atraves de exercicos construir uma logica de programação e algoritmo solida,
atraves de exercicios que vão dificultando ao longo do tempo. */

//Declarando as variaveis que ovu utilizar
double celcius, fahrenheit;

//Pedindo para o usuario digitar um valor em celcius 
Console.Write("Digite um valor em Celcius que converterei para Fahrenheit: ");

//Armazenando o valo do celcius na minha variavel
celcius = double.Parse(Console.ReadLine());

//Fazendo o calculo e armazenando o valo na varialvel
fahrenheit = (celcius * 1.8) + 32;

//Mostrando na tela o resultado da conversão
Console.WriteLine($"Convertido fahrenheit: {fahrenheit}");