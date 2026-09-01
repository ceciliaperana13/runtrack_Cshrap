using System;

class Aventurier
{
    static void DisplayAdventurer(string nom, string classe, int age, int niveau, double bourse, bool estNouveau)
    {
        string statutNouveau = estNouveau ? "est nouveau" : "n'est pas nouveau";
        Console.WriteLine($"L'aventurier {nom}, un {classe} de {age} ans, est niveau {niveau} et a une bourse de {bourse} pièces d'or.");
        Console.WriteLine($"Cet aventurier {statutNouveau}.");
    }

    static void Main(string[] args)
    {
        DisplayAdventurer("Bob", "guerrier", 45, 5, 4530.6, false);
    }
}