string[] mois = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"};
string valeurs;
string val = "";

for (int i = 0; i < mois.Length; i++)
{
    valeurs = $"{mois[i]}";
    Console.WriteLine(val + valeurs);
    val = "   " + val;
}