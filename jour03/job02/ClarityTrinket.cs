using System;
//la classe ClarityTrinket qui implémente IProtectiveItem.
class ClarityTrinket : IProtectiveitem
{
    public int Protection { get; private set; }
    public string Name { get; private set; }

    public ClarityTrinket(int protection, string name)
    {
        Protection = protection;
        Name = name;
    }

    public int Protect(int incomingDamage)
    {
        // reduit les degats entrants en fonction de la protection
        int reducedDamage = incomingDamage - Protection;
        return reducedDamage > 0 ? reducedDamage : 0; // Ne peut pas être négatif
        //afficher
        Console.WriteLine($"{Name}: L’aura du charme absorbe {Protection} points de dégâts mentaux.");
    }
}