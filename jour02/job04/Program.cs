using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Affiche les consignes de sécurité 
        ReturnCard.GetPostRules();
        Console.WriteLine();

        // Création d'une carte via le constructeur principal
        ReturnCard card1 = new ReturnCard("CARD-001", "Alice", DateTime.Now.AddYears(1), CardType.Premium);
        Console.WriteLine($"Carte créée pour {card1.OwnerName} ({card1.Type}) - N° {card1.CardNumber}");
        Console.WriteLine($"Total de cartes émises : {ReturnCard.TotalCardsIssued}");

        // Création d'une copie via le constructeur de copie
        ReturnCard card2 = new ReturnCard(card1);
        card2.OwnerName = "Bob"; // on peut modifier la copie sans affecter l'original
        Console.WriteLine($"\nCarte copiée pour {card2.OwnerName} ({card2.Type}) - N° {card2.CardNumber}");
        Console.WriteLine($"Total de cartes émises : {ReturnCard.TotalCardsIssued}");

        Console.WriteLine($"\nL'original appartient toujours à : {card1.OwnerName}");

        Console.WriteLine("\nAppuyez sur une touche pour quitter...");
        Console.ReadKey();
    }
}