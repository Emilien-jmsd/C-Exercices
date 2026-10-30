string MotPasse = "secret";
Console.WriteLine("Entrez votre mot de passe");
string reponse = Console.ReadLine();
if (MotPasse==reponse)
{
    Console.WriteLine("Accès autorisée");
}
else
{
    Console.WriteLine("Accès refusée");
}

