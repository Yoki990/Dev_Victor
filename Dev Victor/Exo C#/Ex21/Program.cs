using System.Numerics;

(float addition, float difference, float quotient, float produit) operation;

Console.Write($"Veuillez saisir le nombre n°1: ");
float nb1 = float.Parse(Console.ReadLine());
Console.Write($"Veuillez saisir le nombre n°2: ");
float nb2 = float.Parse(Console.ReadLine());

operation.addition = nb1 + nb2;
operation.difference = nb1 - nb2;
operation.quotient = nb1 / nb2;
operation.produit = nb1 * nb2;

Console.WriteLine();

Console.WriteLine($"L'addition de {nb1} et {nb2} est de {operation.addition}");
Console.WriteLine($"La différence entre {nb1} et {nb2} est de {operation.difference}");
Console.WriteLine($"Le quotient de {nb1} et {nb2} est de {operation.quotient}");
Console.WriteLine($"Le produit de {nb1} et {nb2} est de {operation.produit}");