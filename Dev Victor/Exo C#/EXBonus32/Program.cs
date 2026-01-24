using System.Numerics;

int[] nombre = new int[10];
string valeurs;
string val = "";

for (int i = 0; i < nombre.Length; i++)
{
    Console.Write($"Saisir la valeur {i+1}: ");
    int nb = int.Parse(Console.ReadLine());

    nombre[i] = nb;
}

Console.WriteLine("Affichage des valeurs du tableau :\n");

for (int j = 0; j < nombre.Length; j++)
{
    valeurs = $"{nombre[j]}";
    Console.WriteLine(val + valeurs);
    val = "     " + val;
}