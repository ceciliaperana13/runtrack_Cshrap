using System;

namespace TeleportRitual
{
    /// Second gestionnaire de l'événement de progression
    public class SurveillantDeStabilite
    {
        private const double SeuilAlerte = 10.0;
        private double stabilitePrecedente = 100.0;

        public void Surveiller(object? sender, RitualProgressEventArgs e)
        {
            double chute = stabilitePrecedente - e.Stabilite;

            if (chute >= SeuilAlerte)
            {
                Console.WriteLine(
                    $"  !! ALERTE RUPTURE MAGIQUE : chute de stabilité de {chute:F1}% pendant '{e.NomEtape}' " +
                    $"(stabilité actuelle : {e.Stabilite:F1}%) !!");
            }

            stabilitePrecedente = e.Stabilite;
        }
    }
}