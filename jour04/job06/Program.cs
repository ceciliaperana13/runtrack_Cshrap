using System;
using System.Collections.Generic;
using System.Linq;

namespace CombatHedge
{
    public static class Program
    {
        public static void Main()
        {
            var hedge = new HedgeBoss(seed: 42);
            var groupe = new Groupe();
            var rng = new Random(7);
            var journalCombat = new List<TourDeCombat>();

            Console.WriteLine("Le combat contre Hedge, retranché derrière le Miasme Miroir, commence !\n");

            int numeroTour = 1;
            while (!hedge.EstDetruit)
            {
                var etat = hedge.ChangerPosture();
                int shieldPowerAvant = etat.ShieldPower;

                double contrecoup = LogiqueDeCombat.CalculerContrecoup(shieldPowerAvant);
                groupe.SubirContrecoup(contrecoup);

                string attaqueChoisie = LogiqueDeCombat.ChoisirAttaque(etat, rng);
                string riposteIdeale = LogiqueDeCombat.DeterminerRiposteIdeale(etat);
                bool adaptee = attaqueChoisie == riposteIdeale;

                int delta = adaptee ? -10 : 5;
                hedge.ModifierPuissance(delta);

                var tour = new TourDeCombat(
                    numeroTour, etat.Stance, etat.IsCasting, attaqueChoisie,
                    adaptee, shieldPowerAvant, hedge.ShieldPower, contrecoup);
                journalCombat.Add(tour);

                Console.WriteLine(
                    $"Tour {tour.Numero} : Hedge adopte la posture \"{tour.Stance}\" (isCasting={tour.IsCasting}), " +
                    $"bouclier à {tour.ShieldPowerAvant}.");
                Console.WriteLine(
                    $"  -> Le groupe subit un contrecoup de {tour.Contrecoup:F1} (PV du groupe : {groupe.PointsDeVie}).");
                Console.WriteLine(
                    $"  -> Riposte choisie : {tour.AttaqueChoisie} " +
                    $"({(tour.Adaptee ? "adaptée, -10" : "inadaptée, +5")}) -> bouclier à {tour.ShieldPowerApres}.\n");

                numeroTour++;

                if (numeroTour > 100) break; // garde-fou anti-boucle infinie
            }

            // Vérification LINQ de la destruction du bouclier
            bool boucladDetruit = journalCombat.Any(t => t.ShieldPowerApres <= 0);
            int nombreAttaquesAdaptees = journalCombat.Count(t => t.Adaptee);
            double contrecoupTotal = journalCombat.Sum(t => t.Contrecoup);

            Console.WriteLine("bilan du combat");
            Console.WriteLine($"Bouclier détruit : {(boucladDetruit ? "OUI" : "NON")}");
            Console.WriteLine($"Nombre de tours : {journalCombat.Count}");
            Console.WriteLine($"Attaques adaptées : {nombreAttaquesAdaptees} / {journalCombat.Count}");
            Console.WriteLine($"Contrecoup total subi par le groupe : {contrecoupTotal:F1} (PV restants : {groupe.PointsDeVie})");
        }
    }
}