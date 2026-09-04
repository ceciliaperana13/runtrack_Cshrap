using System;

namespace TeleportRitual
{
    /// Informations transmises à chaque étape du rituel de téléportation : nom de l'étape, pourcentage de progression et stabilité du flux.
    public class RitualProgressEventArgs : EventArgs
    {
        public string NomEtape { get; }
        public int Progression { get; }
        public double Stabilite { get; }

        public RitualProgressEventArgs(string nomEtape, int progression, double stabilite)
        {
            NomEtape = nomEtape;
            Progression = progression;
            Stabilite = stabilite;
        }
    }
}