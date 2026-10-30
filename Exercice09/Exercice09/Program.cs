Console.WriteLine("Entrer une année");
int année = int.Parse(Console.ReadLine());
if (année%4 == 0)
{
    Console.WriteLine("Année bissextile");
}
else
{
    Console.WriteLine("Année non bissextile");
}