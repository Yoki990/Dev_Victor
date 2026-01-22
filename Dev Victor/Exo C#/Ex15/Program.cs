int[] valeur = { 12, 14, -3, 23 };

float compteur = 0;
float somme = 0;
float moyenne = 0;

for (int i = 0; i < valeur.Length; i++)
{
    if (valeur[i] < 0)
    {
        continue;
    }
    else
    {
        compteur++;
        somme = somme + valeur[i];
        moyenne = somme / compteur;
    }
}


Console.WriteLine("Nombre de valeurs valides = " + compteur);

Console.WriteLine("Somme des valeurs valides = "+ somme);

Console.WriteLine("Moyenne des valeurs valides = " + moyenne);