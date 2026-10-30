Console.WriteLine("Quel est votre âge?");
int age=int.Parse(Console.ReadLine());
if (age>=18)
{
    Console.WriteLine("Vous êtes majeur");
}
else
{
    Console.WriteLine("Vous êtes mineur");
}