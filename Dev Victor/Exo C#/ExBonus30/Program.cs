string answer;


Console.WriteLine("Quelle est l'instruction qui permet de sortir d'une boucle en C# ?");
Console.WriteLine("     a) quit");
Console.WriteLine("     b) continue");
Console.WriteLine("     c) break");
Console.WriteLine("     d) exit");
Console.WriteLine();

do
{

    Console.Write("Entrez votre réponse:");

    answer = Console.ReadLine();

    bool goodAnswer = answer == "c";

    if (!goodAnswer) 
        Console.WriteLine("Incorrecte");
    else if (answer != "c")
        Console.WriteLine("Saisie invalide");


} while (answer != "c");
Console.WriteLine();



























/*do
{
Console.WriteLine("Quelle est l'instruction qui permet de sortir d'une bouck en C# ?");
Console.WriteLine("     a) quit");
Console.WriteLine("     b) continue");
Console.WriteLine("     c) break");
Console.WriteLine("     d) exit");
Console.WriteLine();
Console.Write("Entrez votre réponse:");

answer = char.Parse(Console.ReadLine());

if (answer != 'c')
{
    Console.WriteLine("Incorrecte!" + "\n");


    do
    {
        Console.WriteLine("Un nouveau essai ? Oui / Non : ");
        string essai = Console.ReadLine();

        if (essai == "oui")
        {

        }
        else if (essai != "non")
            Console.WriteLine("Je ne comprends pas votre demande.");

    } while (essai != "non");

}

*/
