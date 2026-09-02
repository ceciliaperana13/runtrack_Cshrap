using System;
using System.Collections.Generic;
using Tartaros.Exploration;

class Program
{
    //instanciez GuildSupply, affichez le stock, consommez un objet, puis réaffichez le stock à jour pour valider le résultat.
    static void Main(string[] args)
    {
        // Instanciation de GuildSupply
        GuildSupply guildSupply = new GuildSupply("Guilde des Aventuriers");

        // Affichage du stock initial
        Console.WriteLine($"Stock initial de la {guildSupply.Name}:");
        foreach (var item in guildSupply.ConsumableItems)
        {
            Console.WriteLine($"- {item}");
        }

        // Consommation d'un objet
        string itemToConsume = "Potion de soin";
        if (guildSupply.ConsumableItems.Contains(itemToConsume))
        {
            guildSupply.ConsumableItems.Remove(itemToConsume);
            Console.WriteLine($"\nL'objet '{itemToConsume}' a été consommé.");
        }
        else
        {
            Console.WriteLine($"\nL'objet '{itemToConsume}' n'est pas disponible dans le stock.");
        }

        // Réaffichage du stock après consommation
        Console.WriteLine($"\nStock mis à jour de la {guildSupply.Name}:");
        foreach (var item in guildSupply.ConsumableItems)
        {
            Console.WriteLine($"- {item}");
        }
    }
}