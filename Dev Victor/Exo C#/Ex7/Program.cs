Console.Write("Veuillez saisir une note entre 0 et 20: ");

if (int.TryParse(Console.ReadLine(), out int note))
{
string messageNote = note switch
{
    >=18 and <= 20 => "Excellent",
    >=15 and <= 17 => "Très bien",
    >=12 and <= 14 => "Bien",
    >=10 and <= 11 => "Passable",
    >=0 and <= 9 => "Insuffisant"
};

    Console.WriteLine(messageNote);
}
else
{
    Console.WriteLine("Note invalide");
}


