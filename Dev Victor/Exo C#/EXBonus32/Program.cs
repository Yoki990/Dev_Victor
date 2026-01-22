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


/*Console.WriteLine(nombre[0]);*/
for (int j = 0; j < nombre.Length; j++)
{
    valeurs = $"{nombre[j]}";
    Console.WriteLine(valeurs);

    /*valeurs = val + $"{nombre[j]}";
    val = "     " + valeurs + "     ";
    Console.WriteLine(val);*/
    /*val = "      " + valeurs;*/
}

/*foreach (int note in nombre)
{
    Console.WriteLine(note);
}
Console.WriteLine();*/