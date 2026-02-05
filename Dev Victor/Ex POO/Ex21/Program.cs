using Ex21.Exceptions;

static int calculMoyenne(int[] notes)
{
    int a = 0;
    for (int i = 0; i < notes.Length; i++)
    {
        a += notes[i];
    }
    return a / notes.Length;
}

int[] notes = [20, 12, 20, 9];

if (notes.Length == 0)
{
    throw new InvalidArrayException("Le tableau de notes ne peut pas être vide");
}
else
{
    /*Console.WriteLine("C'est rempli");*/

    for (int i = 0; i < notes.Length; i++)
    {
        if (notes[i] < 0 || notes[i] > 20)
        {
            throw new ArgumentOutOfRangeException("Les notes doivent être entre 0 et 20.");
            break;
        }
    }
}
Console.WriteLine(calculMoyenne([20, 12, 20, 9]));
