using Ex02.Classe;

Console.Write("Veuillez entrer un largeur : ");
int largeur = int.Parse(Console.ReadLine());
Console.Write("Veuillez entrer une hauteur : ");
int hauteur = int.Parse(Console.ReadLine());
Console.WriteLine();

Rectangle monRectangle = new Rectangle(largeur, hauteur);

/*Console.WriteLine($"Perimètre = {v1.perimetre}");
Console.WriteLine($"Surface = {v1.surface}");*/

monRectangle.perimetre();
monRectangle.surface();