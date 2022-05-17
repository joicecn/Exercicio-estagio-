
int tempC, tempF;


Console.WriteLine("Informe a temperatura em °F");
tempF = int.Parse(Console.ReadLine());
tempC = (tempF - 32) * 5 / 9;

Console.WriteLine($"{tempF}°F corresponde a {tempC}°C.");
