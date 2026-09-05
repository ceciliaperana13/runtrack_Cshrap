using System;
using System.Collections.Generic;
using System.Linq;

namespace CombatOrannis
{
   
    public class Meloap
    {
        // Trois fonctions de soutien retournant respectivement 15, 25 et 40
        public List<Func<int>> Soutiens { get; } = new List<Func<int>>
        {
            () => 15,
            () => 25,
            () => 40
        };

        
        public int ExecuterSoutiensFiltres()
        {
            var soutiensValides = Soutiens
                .Select(f => f())
                .Where(puissance => puissance > 20)
                .ToList();

            Console.WriteLine($"  [Meloap] Soutiens retenus (> 20) : [{string.Join(", ", soutiensValides)}]");

            return soutiensValides.Sum();
        }
    }
}