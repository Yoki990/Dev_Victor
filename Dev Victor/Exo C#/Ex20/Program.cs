(double moyenne, string mention) CalculerResultat;
double sommeNotes = 0;
int nbNote = 1;

do
{
    Console.Write($"Veuillez saisir l'âge n°{nbNote}: ");
    double note = double.Parse(Console.ReadLine());
    if (note < 0 || note > 20)
    {
        Console.WriteLine($"Mauvaise saisie !!!");
    }
    else
    {
        sommeNotes += note;
        nbNote++;
    }
}
while (nbNote<=3);

CalculerResultat.moyenne = sommeNotes / 3;

if (CalculerResultat.moyenne < 10)
{
    CalculerResultat.mention = "Échec";
}
else if (CalculerResultat.moyenne >= 10 && CalculerResultat.moyenne < 12)
{
    CalculerResultat.mention = "Passable";
}
else if (CalculerResultat.moyenne >= 12 && CalculerResultat.moyenne < 14)
{
    CalculerResultat.mention = "Assez bien";
}
else if (CalculerResultat.moyenne >= 14 && CalculerResultat.moyenne < 16)
{
    CalculerResultat.mention = "Bien";
}
else
{
    CalculerResultat.mention = "Très bien";
}

Console.WriteLine($"\nLa moyenne est de {CalculerResultat.moyenne}, la mention est {CalculerResultat.mention}");