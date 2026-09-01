using System;

class Envoie
{
    static void Main(string[] args)
    {
        Console.Write("Entre ton nom : ");
        string nom = Console.ReadLine();

        Console.Write("Entre ta classe : ");
        string classe = Console.ReadLine();

        Console.Write("Entre ton niveau : ");
        int niveau = int.Parse(Console.ReadLine());

        Console.WriteLine($"Bienvenue {nom}, {classe} de niveau {niveau}! Ouverture de la porte.");
    }
}