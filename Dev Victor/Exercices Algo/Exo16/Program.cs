Console.WriteLine("Veuillez saisir 20 notes : ");
int x=0;
int y;

for (int i = 0; i < 20; i++)
{
    string? nombre = Console.ReadLine();
    int nb = int.Parse(nombre);
    y = nb;
    if (y < x)
    {
        x = y;
    }
}
Console.WriteLine("La plus petite note saisi est : " + x);

/*
int x=0;
int y;
for (int i = 0; i < 20; i++)
{
    string? nombre = Console.ReadLine();
    int nb = int.Parse(nombre);
    y = nb;
    if (y > x)
    {
        x = y;
    }
}
Console.WriteLine("La plus grande note saisi est : " + x);*/