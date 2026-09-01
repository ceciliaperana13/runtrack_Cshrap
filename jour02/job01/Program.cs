//Créez une énumération PotionType (Health, Mana, Stamina).Créez une classe Order représentant une commande d’un client.
using System;

public enum PotionType
{
    Health,
    Mana,
    Stamina,

}
public class Order
{
    public PotionType Potion { get; set; }
    public int Quantity {get;set;}
    public decimal Price {get;set;}

    public Order(PotionType potion, int quantity, decimal price)
    {
        Potion = potion;
        Quantity = quantity;
        Price = price;
    }
 //creation du main avec int input 

public static void Main(string[] args)
    {
        Console.WriteLine("Entrez le type de potion (Health, Mana, Stamina) :");
        string potionInput = Console.ReadLine();
        PotionType potionType;
        if (!Enum.TryParse(potionInput, true, out potionType))
        {
            Console.WriteLine("Aucune instruction");
            return;
        }

        Console.WriteLine("Entrez la quantité :");
        int quantity;
        if (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
        {
            Console.WriteLine("Quantité invalide.");
            return;
        }

        Console.WriteLine("Entrez le prix :");
        decimal price;
        if (!decimal.TryParse(Console.ReadLine(), out price) || price < 0)
        {
            Console.WriteLine("Prix invalide.");
            return;
        }
        
        Order order = new Order(potionType, quantity, price);
        Console.WriteLine($"Commande créée : {order.Quantity} x {order.Potion} à {order.Price:C} chacun.");
    }
}
