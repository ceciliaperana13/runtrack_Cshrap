using System;

 public enum CardType
{
    Standard,
    Premium,
    VIP
}

public class ReturnCard
{
    // Propriétés d'instance
    public string CardNumber { get; set; }
    public string OwnerName { get; set; }
    public DateTime ExpirationDate { get; set; }
    public CardType Type { get; set; }

    // Champ static qui s'incrémente automatiquement à chaque création d'une carte
    public static int TotalCardsIssued { get; private set; }

    // Constructeur principal
    public ReturnCard(string cardNumber, string ownerName, DateTime expirationDate, CardType type)
    {
        this.CardNumber = cardNumber;
        this.OwnerName = ownerName;
        this.ExpirationDate = expirationDate;
        this.Type = type;

        TotalCardsIssued++;
    }

    // Constructeur de copie 
    public ReturnCard(ReturnCard original)
    {
        // Copier les propriétés de l'original
        this.CardNumber = original.CardNumber;
        this.OwnerName = original.OwnerName;
        this.ExpirationDate = original.ExpirationDate;
        this.Type = original.Type;

        // Incrémenter le compteur de cartes émises
        TotalCardsIssued++;
    }

    // Méthode static : ne dépend d'aucune instance particulière,
    // logique pour une consigne générale du poste de garde
    public static void GetPostRules()
    {
        Console.WriteLine("Consignes de sécurité du poste de garde :");
        Console.WriteLine("- Ne jamais laisser les cartes en dehors de la vue.");
        Console.WriteLine("- Vérifier régulièrement l'état des cartes.");
        Console.WriteLine("- Respecter les protocoles de sécurité.");
    }
}