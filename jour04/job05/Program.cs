using System;

namespace TeleportRitual
{
    public static class Program
    {
        public static void Main()
        {
            var rituel = new TeleportRitual();
            var surveillant = new SurveillantDeStabilite();

            //premier gestionnaire affiche le journal de canalisation
            rituel.ProgressionRituel += (sender, e) =>
                Console.WriteLine($"[Journal] {e.NomEtape} - progression {e.Progression}% - stabilité {e.Stabilite:F1}%");

            //second gestionnaire  surveille la stabilité et signale une chute importante
            rituel.ProgressionRituel += surveillant.Surveiller;

            Console.WriteLine("Vous combinez les outils de la réserve, le parchemin de Hedge et l'aide de Meloap...\n");

            rituel.LancerRituel();

            Console.WriteLine("\nLe rituel est achevé : la brèche s'ouvre directement vers le sommet de Tartaros.");
        }
    }
}