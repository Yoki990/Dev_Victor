/*int lePlusGrandDesDeux(int nb1, int nb2)
*//*{
    if (nb1 > nb2)
    {
        int plusGrand = nb1;
        return plusGrand;
    }
    else
    {
        int plusGrand = nb2;
        return plusGrand;
    }
}*//*

{string plusGrand = (nb1 > nb2) ? $"PlusGrand = {nb1}" : $"PlusGrand = {nb2}"; 
}*/

Console.Write("Veuillez taper un premier nombre : ");
int nb1 = int.Parse(Console.ReadLine());
Console.Write("Veuillez taper un deuxième nombre : ");
int nb2  = int.Parse(Console.ReadLine());

string plusGrand = (nb1 > nb2) ? $"PlusGrand = {nb1}" : $"PlusGrand = {nb2}";

Console.WriteLine(plusGrand);

/*int plusGrand = lePlusGrandDesDeux(nb1, nb2);
Console.Write($"Le nombre le plus grand est {plusGrand} ");*/