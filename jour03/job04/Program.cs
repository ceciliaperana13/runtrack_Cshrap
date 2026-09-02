using System;
using System.Collections.Generic;


//stockez une gargouille et un aventurier fou dans une liste deCorruptedCreature. Faites-leur subir à chacun 20 points de dégâts de miasme et observez la différence d'affichage.
class Program 
{
    static void Main(string[] args) 
    {
        // Création d'une liste de CorruptedCreature
        List<CorruptedCreature> creatures = new List<CorruptedCreature>();

        // Instanciation d'une Gargouille corrompue
        CorruptedGargoyle gargoyle = new CorruptedGargoyle("Gargouille",100,15);
        creatures.Add(gargoyle);
        
        // Application de 20 points de dégâts de miasme à chaque créature
        foreach (var creature in creatures) 
        {
            Console.WriteLine($"Avant dégâts : {creature.Name} a {creature.Health} PV.");
            creature.TakeMiasmaDamage(20);
            Console.WriteLine($"Après dégâts : {creature.Name} a {creature.Health} PV.\n");
        }
    }
}