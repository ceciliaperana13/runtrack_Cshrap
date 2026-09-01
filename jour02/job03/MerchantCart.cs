using System;

public class MerchantCart
{
    // Propriété encapsulée : lecture publique, écriture privée 
    public int Gold { get; private set; }

    public MerchantCart(int startingGold = 0)
    {
        Gold = startingGold;
    }

    // Ajoute une somme donnée au montant de pièces d'or
    public void AddGold(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Le montant à ajouter ne peut pas être négatif.");
            return;
        }

        Gold += amount;
    }

    // Retire une somme donnée si la réserve est suffisante
    public bool PayFee(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Le montant à payer ne peut pas être négatif.");
            return false;
        }

        if (amount > Gold)
        {
            Console.WriteLine($"Paiement refusé : la réserve actuelle ({Gold} PO) est insuffisante pour payer {amount} PO.");
            return false;
        }

        Gold -= amount;
        return true;
    }
}