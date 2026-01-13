int compter_lettre_a = 0;
int compter_lettre_t = 0;
int compter_lettre_c = 0;
int compter_lettre_g = 0;
int compter_lettre_total;

Console.Write("Veuillez entrer la chaine ADN : ");
string adn = Console.ReadLine();

for (int i = 0;i < adn.Length; i++)
{
    if (adn[i] == 'a')
    {
        compter_lettre_a += 1;
    }
    else if (adn[i] == 't')
    {
        compter_lettre_t += 1;
    }
    else if (adn[i] == 'c')
    {
        compter_lettre_c += 1;
    }
    else if (adn[i] == 'g')
    {
        compter_lettre_g += 1;
    }
}
compter_lettre_total = compter_lettre_a + compter_lettre_c + compter_lettre_g + compter_lettre_t;

Console.WriteLine($"Type de adn : {adn.GetType()}");

Console.WriteLine($"a : {compter_lettre_a}");
Console.WriteLine($"t : {compter_lettre_t}");
Console.WriteLine($"c : {compter_lettre_c}");
Console.WriteLine($"g : {compter_lettre_g}");
Console.WriteLine($"Total : {compter_lettre_total}");
Console.WriteLine($"longueur : {adn.Length}");

if (compter_lettre_total == adn.Length)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}