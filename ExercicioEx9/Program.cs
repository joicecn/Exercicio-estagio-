double a, b, total;

Console.WriteLine("Digite o valor de a");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de b");
b = double.Parse(Console.ReadLine());

total = a % b;

if (b == 0) {

    Console.WriteLine("Não é possivel dividir por 0");
}

else
{
    Console.WriteLine(total);
}