
double a, b, total;

Console.WriteLine("Digite o valor de a");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de b");
b = double.Parse(Console.ReadLine());

total = a - b ;

if (total > 0) {

    Console.WriteLine("Positivo");

}

else {
    Console.WriteLine("Negativo");
}


