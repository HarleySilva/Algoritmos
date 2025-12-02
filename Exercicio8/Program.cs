int numero, numeroant, numerodep;

Console.Write("Escreva um numero: ");
numero = int.Parse(Console.ReadLine());

numeroant = numero - 1;

numerodep = numero + 1;

Console.WriteLine($"{numeroant} {numero} {numerodep}");