using Ex14.Classes;

/*Adresse p1 = new Adresse(4, "rue des Champs Elysées", "Paris", "75000");

Console.WriteLine(p1.ToString());*/

/*Lettre lettre = new Lettre(4, "rue des Champs Elysées", "Paris", "75000", "Eudes", "Jean", "Rue de la liberté", "Toto", "Titi", "blablabla", "Envoyée");
*/

/*Lettre lettre = new Lettre(4, "rue des Champs Elysées", "Paris", "75000", "Eudes", "Jean",
    new Adresse(9,"Rue de la liberté", "Lille", "59000"), new User(9,"rue", "paris", "58500", "tangui","yoplait", new Adresse(9, "rue", "paris", "58500")),
    new User(9, "rue", "paris", "58500", "tangui", "yoplait", new Adresse(9, "rue", "paris", "58500")), "blablabla", "Envoyée");*/



Lettre l2 = new Lettre(new User("Polo", "Marco", new Adresse(9, "rue des Oliviers", "Lille", "59000")), new User("Eudes", "Jean", new Adresse(4, "rue des Champs Elysées", "Paris", "75000")), "blablabla");

Console.WriteLine(l2);

l2.Envoyer();
Console.WriteLine(l2);

l2.Lire();
Console.WriteLine(l2);