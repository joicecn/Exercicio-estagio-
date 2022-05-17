
int tempC, tempF;


Console.WriteLine("Informe a temperatura em °C");
tempC = int.Parse(Console.ReadLine());
tempF = ((9 * tempC) + 160) / 5;

Console.WriteLine($"{tempC}°C corresponde a {tempF}°F.");