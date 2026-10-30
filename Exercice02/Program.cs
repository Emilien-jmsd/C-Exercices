Console.WriteLine("entrer un nombre : ");
int nombre=int.Parse(Console.ReadLine());
if (nombre>0)
{
    Console.WriteLine("Positif");
}
else if (nombre<0)
{
    Console.WriteLine("Négatif");
}
else
{
    Console.WriteLine("Nul");
}