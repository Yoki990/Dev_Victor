Console.Write("Veuillez saisir une température: ");
float celsius = float.Parse(Console.ReadLine());

float Fahrenheit = (celsius * 9 / 5)+32;

Console.WriteLine($"{celsius}°C = {Fahrenheit}°F");