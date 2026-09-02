using System;
//simulez une attaque mentale de 15points sur une amulette ayant protection à 10, etaffichez le montant de dégâts restants à subir.
class Program
{
    static void Main()
    {
        IProtectiveitem amulet = new ClarityTrinket(10, "Amulette de Clarté");
        int incomingDamage = 15;
        int remainingDamage = amulet.Protect(incomingDamage);
        Console.WriteLine($"Dégâts restants à subir: {remainingDamage}");
    }
}