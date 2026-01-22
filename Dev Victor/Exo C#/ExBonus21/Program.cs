Console.WriteLine("--- Menus et sous-menus ---");
Console.WriteLine();
Console.WriteLine("Table des matières");
Console.WriteLine();

for (int chapitre=1; chapitre<=3; chapitre++)
{
    Console.WriteLine($"        Chapitre {chapitre}");

    for (int sousPartie=1; sousPartie<=3; sousPartie++)
    {
        Console.WriteLine($"            -Partie {chapitre}.{sousPartie}");
    }   
    
}