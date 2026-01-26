char[] table = new char[26];
int compteur = 65;
string valeurs;
string val = "";
char character = '\0';

for (int i = 0;  i < table.Length;  i++)
{
    character = Convert.ToChar(compteur);
    table[i] = character;
    compteur++;
    valeurs = $"{table[i]}";
    Console.WriteLine(val + valeurs);
    val = "   " + val;
}