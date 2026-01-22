int[] valeur = { 12, 14, 15, 23 };

int compteur = 0;
int compteur2 = 1;

while (compteur2 < valeur.Length)
{
    if (valeur[compteur] == valeur[compteur2])
    {
        Console.WriteLine($"La valeur n°{compteur} ({valeur[compteur]}) et la valeur n°{compteur2} ({valeur[compteur2]}) sont deux valeurs consécutives identiques");
        break;
    }
    compteur++;
    compteur2++;
    continue;

}
if (compteur == valeur.Length-1 && compteur2 == valeur.Length)
{
    Console.WriteLine($"Aucune valeurs consécutives identiques");
}



