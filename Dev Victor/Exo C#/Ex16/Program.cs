int[] age = new int[5];

int compteur = 1;
int invalides = 0;

do
{
    Console.Write($"Veuillez saisir l'âge n°{compteur}: ");
    int age2 = int.Parse(Console.ReadLine());

    if (age2 < 0 || age2 > 120)
    {
        Console.WriteLine($"Mauvaise saisie !!!");
        invalides++;
    }
    else
    {
        age[compteur - 1] = age2;
        compteur++;
    }
}
while (compteur < age.Length + 1);

Console.WriteLine($"\nÂge 1: {age[0]}");
Console.WriteLine($"Âge 2: {age[1]}");
Console.WriteLine($"Âge 3: {age[2]}");
Console.WriteLine($"Âge 4: {age[3]}");
Console.WriteLine($"Âge 5: {age[4]}\n");
Console.WriteLine($"Nombres de saisies invalides : {invalides}");