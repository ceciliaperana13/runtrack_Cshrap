//main de merchantCart.cs
using System;

public class Program
{
    public static void Main(string[] args)
    {
        MerchantCart cart = new MerchantCart(100);
        Console.WriteLine($"Solde initial : {cart.Gold} PO");

        cart.AddGold(50);
        Console.WriteLine($"Après ajout de 50 PO : {cart.Gold} PO");

        bool success1 = cart.PayFee(200);
        Console.WriteLine($"Tentative de payer 200 PO : {(success1 ? "réussie" : "échouée")} | Solde : {cart.Gold} PO");

        bool success2 = cart.PayFee(100);
        Console.WriteLine($"Tentative de payer 100 PO : {(success2 ? "réussie" : "échouée")} | Solde : {cart.Gold} PO");

        // cart.Gold = 9999; 

        Console.WriteLine("\nAppuyez sur une touche pour quitter...");
        Console.ReadKey();
    }
}