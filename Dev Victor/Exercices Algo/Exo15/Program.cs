/*int i = 0;

for (int prod = 1; prod<= 10; prod++)
{
    for (int resultat = prod * i; resultat <= 30; resultat = prod * i)
    {
        Console.WriteLine(prod + " x " + i + " = " + resultat);
        i++;
    };
   
   i = 0;
}*/

for (int prod = 1; prod <= 10; prod++)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(prod + " x " + i + " = " + i * prod);
    }
    Console.WriteLine(" ");

}
