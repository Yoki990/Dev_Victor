Console.Write("Veuillez saisir un mot: ");
float nbStr = float.Parse(Console.ReadLine());

int nb = (int)Math.Round(nbStr,0, MidpointRounding.ToZero);
Console.WriteLine(nb);

int cible=0;
int compteur = 1;

while (cible != nb)