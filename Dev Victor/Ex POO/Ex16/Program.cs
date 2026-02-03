string motsStr;
int compteurListe = 0;
List<string> mots = new List<string>();

do
{
    Console.Write("Veuillez saisir un mot: ");
    motsStr = Console.ReadLine();
    if (motsStr != "stop")
    {
        mots.Add(motsStr);
        compteurListe++;
    }
} while (motsStr != "stop");

Console.WriteLine($"\nNombre de mots saisis: {compteurListe}");

foreach (string mot in mots)
    Console.WriteLine(mot);