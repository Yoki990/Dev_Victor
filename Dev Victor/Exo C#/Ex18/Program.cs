int[] notes = { 1, 3, 15, 23 };

int compteur = 0;

while (compteur < notes.Length)
{
    if (notes[compteur] < 10)
    {
        notes[compteur] = 10;
        compteur++;
    }
    else if (notes[compteur] > 20)
    {
        notes[compteur] = 20;
        compteur++;
    }
    else
    {
        compteur++;
    }
}

foreach (int note in notes)
{
    Console.WriteLine(note);
}
Console.WriteLine();