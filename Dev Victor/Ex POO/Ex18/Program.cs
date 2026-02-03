using Ex18.Classes;
using System;

Bibliotheque biblio = new Bibliotheque();

Random random = new Random();

List<Livre> book = new List<Livre>();

book.Add(new Livre(1, "Chaperon rouge", "Charles Perrault", random.Next(10, 51)));
book.Add(new Livre(2, "Toto", "Titi Tutu", random.Next(10, 51)));
book.Add(new Livre(3, "L'Ecume des jours", "Boris Vian", random.Next(10, 51)));

foreach (Livre livre in book)
{
    biblio.AfficherTousLivres();
}