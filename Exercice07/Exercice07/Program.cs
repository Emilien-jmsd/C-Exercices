Console.WriteLine("Quel est le montant de l'achat?");
int montant = int.Parse(Console.ReadLine());
if (montant > 100)
{
    Console.WriteLine("Réduction de 10 %");
}
else
{
    Console.WriteLine("Pas de réduction");
}
