using System;
using System.Collections.Generic;
using Tartaros.Exploration;

class Program
{
    static void Main(string[] args)
    {
        //Liste des sorts
        List<AntiShadowSpell> spells = new List<AntiShadowSpell>
        {
            new PurifyingLightSpell(),
            new DisruptionWaveSpell()
        };

        int currentMana = 30;
        string target = "Ombre maléfique";

        Console.WriteLine($"affrontement contre : {target}");
        Console.WriteLine($"Mana initial : {currentMana}\n");

        foreach (AntiShadowSpell spell in spells)
        {
            if (spell.CanCast(currentMana))
            {
                currentMana -= spell.ManaCost;
                spell.Cast(target);
                Console.WriteLine($"Mana restant : {currentMana}\n");
            }
            else
            {
                Console.WriteLine($"Mana insuffisant pour détruire l'ombre avec {spell.Name}\n");
            }
        }

        Console.WriteLine("Fin");
    }
}