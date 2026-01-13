Console.WriteLine("Veuillez saisir un nombre : ");
string? nombre = Console.ReadLine();
int nb = int.Parse(nombre);
int j = 0;

for (int i = 1; i <=nb; i++)
{
    j = j + i;   
}
Console.WriteLine(j);


/*for (int i = 1; i < 10; i++)
{
    Console.WriteLine(i);
}*/