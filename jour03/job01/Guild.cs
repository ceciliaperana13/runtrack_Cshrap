using System;
using System.Collections.Generic;

class Guild
{
    // 1méthode ShowSupplies qui affiche dans la console la liste complète des consommables.
    public void ShowSupplies(List<string> consumableItems)
    {
        Console.WriteLine("Liste des consommables:");
        foreach (string item in consumableItems)
        {
            Console.WriteLine($"- {item}");
        }
    }

    // 2méthode AddSupply qui retire un objet donné de la liste et affiche un message de confirmation.
    public void AddSupply(List<string> consumableItems, string item)
    {
        if (consumableItems.Contains(item))
        {
            consumableItems.Remove(item);
            Console.WriteLine($"L'objet '{item}' a été retiré des consommables.");
        }
        else
        {
            Console.WriteLine($"L'objet '{item}' n'est pas dans la liste des consommables.");
        }
    }
}