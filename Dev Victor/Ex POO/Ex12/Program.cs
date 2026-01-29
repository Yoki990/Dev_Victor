using Ex12.Classes;
using Ex12.Interfaces;

Voiture voiture = new Voiture("Toto", "Ford");
VoitureHybride voitureHybride = new VoitureHybride("Tata", "Peugeot");
Hydravion hydravion = new Hydravion("Tuto", "Hydra");

IElectrique[] recharge = { voitureHybride };

foreach (IElectrique ele in recharge)
{
    ele.Recharger();
}
Console.WriteLine();
IFlottant[] flottant = {hydravion};

foreach (IFlottant flo in flottant)
{
    flo.Naviguer();
}
IMotorise[] motor = {voiture, voitureHybride, hydravion };
Console.WriteLine();
foreach (IMotorise mot in motor)
{
    mot.Demarrer();
}

IVolant[] voler = {hydravion};
Console.WriteLine();
foreach (IVolant vol in voler)
{
    vol.Decoller();
    vol.Atterir();
}