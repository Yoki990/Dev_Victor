Console.Write("Veuillez saisir un mot: ");
string motStr = Console.ReadLine();

int voyelle=0;

foreach (char lettre in motStr)
{
    if (lettre == 'a' || lettre == 'e' || lettre == 'i' || lettre == 'o' || lettre == 'u' || lettre == 'y')
    {
        voyelle++;
    }
}

Console.WriteLine($"Dans le mot {motStr}, il y a {voyelle} voyelles.");
