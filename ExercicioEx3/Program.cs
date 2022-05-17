
double vendasMaio, taxa, valorFinal;

Console.WriteLine("Informe o valor das vendas");
vendasMaio = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor da taxa:.");
taxa = double.Parse(Console.ReadLine());

valorFinal = vendasMaio * taxa;

Console.WriteLine($"O valor de R$ {valorFinal}.");