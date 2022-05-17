
double pesoIdeal;
float altura;

Console.WriteLine("Digite a altura");
altura = int.Parse(Console.ReadLine());
pesoIdeal = 72.7 * altura;

Console.WriteLine($" {altura} corresponde a {pesoIdeal}");