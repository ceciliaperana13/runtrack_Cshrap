
using System;

class FicheAventurier
{
    static void Communicate(string message)
    {
        Console.WriteLine(message);
    }

    static void FillCharacterSheet()
    {
    string nom = "Melvin";
    int age = 99;
    int niveau = 0;
    string classe = "trotro";
    decimal pièce = 100000000000000000;
    bool estnouveau = true;

        Communicate($"Nom : {nom}");
        Communicate($"Âge : {age}");
        Communicate($"Niveau : {niveau}");
        Communicate($"Classe : {classe}");
        Communicate($"Pièces d'or : {pièce}");
        Communicate($"Nouveau : {estnouveau}");
    }

    static void Main(string[] args)
    {
        FillCharacterSheet();
    }
}