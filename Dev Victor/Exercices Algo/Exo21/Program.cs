int[] tableau = new int[15];

for (int i = 0; i < tableau.Length; i++)
{
    Console.Write($"Veuillez entrer le nombre {i + 1} : ");
    int nombre = int.Parse(Console.ReadLine());
    tableau[i] = nombre;
}

/*for (int i = 0; i < tableau.Length; i++)
{
    Console.WriteLine(tableau[i]);
}*/

Console.WriteLine("La longueur du tableau est de : " + tableau.Length);

foreach (int j in tableau)
{
    Console.WriteLine(j);
}