int tempStr;
int compteurBon = 0;
int compteurFaux = 0;


List<int> temperature = new List<int>();

do
{
    Console.Write("Veuillez saisir une température: ");
    tempStr = int.Parse(Console.ReadLine());
    if (tempStr != -999 && (tempStr>=-50 && tempStr <=50))
    {
        temperature.Add(tempStr);
        compteurBon++;
    }
    else
    {
        compteurFaux++;
    }
} while (tempStr != -999);

Console.WriteLine($"\nNombre de saisis valides: {compteurBon}");
Console.WriteLine($"\nNombre de saisis erronées: {compteurFaux-1}");

temperature.Sort();

Console.WriteLine();

Console.WriteLine($"La température la plus basse saisie est : {temperature[0]}");
Console.WriteLine($"La température la plus haute saisie est : {temperature[temperature.Count -1]}");