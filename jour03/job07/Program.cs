using System;

namespace CombatGolem
{
    public static class Program
    {
        public static void Main()
        {
            var golem = new ReceptacleGolem();
            var rng = new Random();
            int pointsDeVieHeros = 100;
            int tour = 1;

            Console.WriteLine("Les portes se referment. La statue s'anime : le Golem Réceptacle vous fait face !\n");

            while (!golem.EstVaincu && pointsDeVieHeros > 0)
            {
                Console.WriteLine($"tour {tour}");

                // Le héros attaque
                int degatsInfliges = rng.Next(15, 26);
                Console.WriteLine("Vous portez une attaque contre le golem !");
                golem.TakeDamage(degatsInfliges);

                // Le golem riposte, sauf s'il vient d'être vaincu
                if (!golem.EstVaincu)
                {
                    golem.ExecutePhasePattern();

                    int degatsSubis = rng.Next(5, 16);
                    pointsDeVieHeros = Math.Max(0, pointsDeVieHeros - degatsSubis);
                    Console.WriteLine($"  Vous subissez {degatsSubis} dégâts (vos PV : {pointsDeVieHeros}/100).");
                }

                Console.WriteLine();
                tour++;
            }

            if (golem.EstVaincu)
            {
                Console.WriteLine("Le golem s'effondre à genoux dans un bruit sourd...");
                Console.WriteLine("Dans un geste lent et pesant, il plonge sa main au centre de son torse fissuré");
                Console.WriteLine("pour en extraire un objet étincelant. Les runes sur son corps s'éteignent peu à peu,");
                Console.WriteLine("puis il s'écroule et se brise en morceaux, sa main inerte retenant l'objet.");
                Console.WriteLine("\nEn vous approchant des décombres, vous récupérez L'Égide.");
            }
            else
            {
                Console.WriteLine("Vous succombez sous les assauts du golem...");
            }
        }
    }
}