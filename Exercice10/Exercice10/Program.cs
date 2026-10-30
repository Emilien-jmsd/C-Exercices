Console.WriteLine("entrer le nombre a : ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("entrer le nombre b : ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("entrer + ou - ");
string c = Console.ReadLine();
if (c == "+")
{
    Console.WriteLine(a + b);
}
else if(c == "-")
{
    Console.WriteLine(a - b);
}
else
{
    Console.WriteLine("Opération inconnue");
}


