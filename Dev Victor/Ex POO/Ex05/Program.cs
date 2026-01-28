using Ex05.Classe;

Salarie s1 = new Salarie("Chloé", "Secrétaire", 24_000);
Salarie s2 = new Salarie("Pierre", "Directeur", 30_000);
Salarie s3 = new Salarie("Sam", "R.H.", 36_000);

Console.WriteLine(s1.ToString());
Console.WriteLine(s2.ToString());
Console.WriteLine(s3.ToString());
Salarie.AfficherSalaire();