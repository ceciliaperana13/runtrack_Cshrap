using System;
using System.Collections.Generic;

public class Program
{
    // Affiche uniquement les monstres marqués comme dangereux
    public static void DisplayDangerousMonsters(List<Monster> monsters)
    {
        Console.WriteLine("Monstres dangereux :");
        foreach (Monster monster in monsters)
        {
            if (monster.IsDangerous)
            {
                Console.WriteLine($"- {monster.Name} (PV : {monster.Health})");
            }
        }
    }

    // Calcule le total des points de vie de tous les monstres
    public static int GetTotalHealth(List<Monster> monsters)
    {
        int total = 0;
        foreach (Monster monster in monsters)
        {
            total += monster.Health;
        }
        return total;
    }

    // Récupère le nom du monstre qui a le plus de points de vie
    public static string GetStrongestMonsterName(List<Monster> monsters)
    {
        if (monsters.Count == 0)
        {
            return null;
        }

        Monster strongest = monsters[0];
        foreach (Monster monster in monsters)
        {
            if (monster.Health > strongest.Health)
            {
                strongest = monster;
            }
        }
        return strongest.Name;
    }

    public static void Main(string[] args)
    {
        List<Monster> monsters = new List<Monster>
        {
            new Monster("Gobelin", 15, false),
            new Monster("Ogre", 60, true),
            new Monster("Rat géant", 8, false),
            new Monster("Dragon des cavernes", 120, true)
        };

        // Affichage des monstres dangereux
        DisplayDangerousMonsters(monsters);

        // Total des points de vie
        int totalHealth = GetTotalHealth(monsters);
        Console.WriteLine($"\nTotal des points de vie de la salle : {totalHealth}");

        // Monstre le plus fort
        string strongestName = GetStrongestMonsterName(monsters);
        Console.WriteLine($"Monstre avec le plus de PV : {strongestName}");

        Console.WriteLine("\nAppuyez sur une touche pour quitter...");
        Console.ReadKey();
    }
}