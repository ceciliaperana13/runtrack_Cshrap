using System;
using System.Collections.Generic;

namespace MixMannequins
{
    public static class Program
    {
        static List<string> ListTargets(List<string> targets)
        {
            Console.WriteLine(string.Join(" -> ", targets));
            return targets;
        }
        ///melange aléatoirement la liste de mannequins passée en paramètre
        static List<string> Mix(List<string> targets)
        {
            var rng = new Random();

            for (int i = targets.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (targets[i], targets[j]) = (targets[j], targets[i]);
            }

            return targets;
        }

        public static void Main()
        {
            List<string> targets = new List<string>
            {
                "Premier", "Deuxième", "Troisième", "Quatrième", "Cinquième"
            };

            Console.Write("Combien de fois voulez-vous mélanger la liste ? ");
            int x = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= x; i++)
            {
                ListTargets(targets);
                Mix(targets);
                Console.WriteLine($"La liste est mélangée {i} fois\n");
            }
        }
    }
}