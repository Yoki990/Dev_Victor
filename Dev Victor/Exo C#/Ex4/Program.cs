using System.ComponentModel.DataAnnotations;

Console.Write("Donner la longueur du rectangle: ");
int longueur = int.Parse(Console.ReadLine());
Console.Write("Donner la largeur du rectangle: ");
int largeur = int.Parse(Console.ReadLine());

int perimetre = 2*(longueur+largeur);
int aire = longueur * largeur;

Console.WriteLine($"Le périmètre du rectangle est de {perimetre} et l'aire vaut {aire}");