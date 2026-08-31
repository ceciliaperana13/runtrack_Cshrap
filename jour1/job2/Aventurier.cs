using System;

class FicheAventurier
{
    static void Main(string[] args)
    {
        // Déclaration des variables de la fiche d'aventurier
        string nom = "TOTO";
        int age = 35;
        int niveau = 12;
        string classe = "Guerrier";
        int piecesOr = 250;
        bool nouveau = false;

        // Affichage des informations dans le terminal
        Console.WriteLine(" Fiche d'aventurier");
        Console.WriteLine("Nom : " + nom);
        Console.WriteLine("Âge : " + age);
        Console.WriteLine("Niveau : " + niveau);
        Console.WriteLine("Classe : " + classe);
        Console.WriteLine("Pièces d'or : " + piecesOr);
        Console.WriteLine("Nouveau joueur : " + nouveau);
    }
}