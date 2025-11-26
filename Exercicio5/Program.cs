/* == Pedir para um usuario digitar três numero e mostrar o resultado da media deles == */
/* Meu objetivo é atraves de exercicos construir uma logica de programação e algoritmo solida,
atraves de exercicios que vão dificultando ao longo do tempo. */

//Estou declarando 3 variaveis para armazenar os valores digitados pelo usuario
int numero1, numero2, numero3;

//Pedindo ao usuario que digite um numero para calcular a media
Console.Write("Vamos calcular sua media, digite um numero: ");

//Aqui armazeno o numero que o digitar
numero1 = int.Parse(Console.ReadLine());

//Pedindo ao usuario que digite outro numero
Console.Write("Digite outro numero: ");

//Aqui armazeno o segundo numero que o digitar
numero2 = int.Parse(Console.ReadLine());

//Pedindo ao usuario que digite o terceiro numero
Console.Write("Digite mais um numero: ");

//Aqui armazeno o numero que o digitar
numero3 = int.Parse(Console.ReadLine());

//Aqui calculo o resultado da media e armazeno em uma variavel
int resultado = (numero1 + numero2 + numero3) / 3;

//Apenas um separador
Console.WriteLine("====================");

Console.WriteLine($"A media entre {numero1}, {numero2} e {numero3} é {resultado}");