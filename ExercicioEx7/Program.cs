
double n1, n2, n3, n4, mediaAluno;

Console.WriteLine("Digite a n1");

n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a n2");

n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a n3");

n3 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a n4");

n4 = double.Parse(Console.ReadLine());

mediaAluno = (n1 + n2 + n3 + n4) / 4;
if (mediaAluno >= 7)
{
    Console.WriteLine("Aprovado!");
}

else {
    Console.WriteLine("Reprovado");
}



