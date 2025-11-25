int idade;
string separador = "-------------------";

Console.Write("Digite a sua idade: ");
idade = int.Parse(Console.ReadLine());

Console.WriteLine(separador);

if (idade >= 18)
{
    Console.WriteLine("Você é adulto");
}
else
{
    Console.WriteLine("Você ainda é menor");
}
