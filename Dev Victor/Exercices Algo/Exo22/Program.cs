int[][] matrice = new int[3][];

matrice[0] = new int[15];
matrice[1] = new int[15];
matrice[2] = new int[15];

for(int i = 0; i < matrice[0].Length; i++)
{
    Console.Write($"Veuillez insérer la note n°{i+1} en math: ");
    int math = int.Parse(Console.ReadLine());
    matrice[0][i] = math;
}

for (int i = 0; i < matrice[1].Length; i++)
{
    Console.Write($"Veuillez insérer la note n°{i+1} en geographie: ");
    int geographie = int.Parse(Console.ReadLine());
    matrice[1][i] = geographie;
}

for (int i = 0; i < matrice[2].Length; i++)
{
    Console.Write($"Veuillez insérer la note n°{i+1} en histoire: ");
    int histoire = int.Parse(Console.ReadLine());
    matrice[2][i] = histoire;
}

Console.Write("\n" + "Notes en Maths: ");
foreach (int valeur0 in matrice[0])
{
    Console.Write(valeur0 + " , ");
}
Console.Write("\n" +"Notes en géographie: ");
foreach (int valeur1 in matrice[1])
{
    Console.Write(valeur1 + " , ");
}
Console.Write("\n" + "Notes en histoire: ");
foreach (int valeur2 in matrice[2])
{
    Console.Write(valeur2 + " , ");
}