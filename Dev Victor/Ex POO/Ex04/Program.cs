using Ex04.Classe;

Chien chien1 = new Chien("Lassie", "Colley", 10, "");
Chien chien2 = new Chien("Beethoven", "Saint-Bernard", 10, "");

chien1.Nom = "Belle";
chien1.Race = "Saint-Bernard";
chien1.Age = 5;

Console.WriteLine(chien1.ToString());
Console.WriteLine(chien2.ToString());
Console.WriteLine();

Chien.NomDuChenil = "Parc";

Console.WriteLine(chien1.ToString());
Console.WriteLine(chien2.ToString());

Chien.NombreChien();

