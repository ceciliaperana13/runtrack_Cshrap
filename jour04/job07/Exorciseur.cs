using System;

namespace ExorcismeSameth
{
    public static class Exorciseur
    {
        private const int SeuilConscience = 20;

    
        public static (int PhysicalHealth, int CorruptionLevel, bool IsConscious) Exorcise(
            (int PhysicalHealth, int CorruptionLevel, bool IsConscious) etat)
        {
            int nouvelleSante = Math.Clamp(etat.PhysicalHealth - 20, 0, 100);
            int nouvelleCorruption = Math.Max(0, etat.CorruptionLevel - 15);
            bool conscient = nouvelleSante >= SeuilConscience;

            return (nouvelleSante, nouvelleCorruption, conscient);
        }

        public static (int PhysicalHealth, int CorruptionLevel, bool IsConscious) PasserSansAction(
            (int PhysicalHealth, int CorruptionLevel, bool IsConscious) etat)
        {
            int nouvelleSante = Math.Clamp(etat.PhysicalHealth + 10, 0, 100);
            int nouvelleCorruption = etat.CorruptionLevel + 5;
            bool conscient = nouvelleSante >= SeuilConscience;

            return (nouvelleSante, nouvelleCorruption, conscient);
        }

        /// diagnostic à afficher.
        public static string AnalyserEtat((int PhysicalHealth, int CorruptionLevel, bool IsConscious) etat)
        {
            return etat switch
            {
                (> 0, <= 0, _) => "Sameth est libéré !",
                (> 20, > 0, true) => "Sameth résiste, poursuite de la purification avec L'Égide.",
                (<= 20, > 0, false) => "Sameth a perdu connaissance.",
                (<= 0, _, _) => "Le corps de Sameth n'a pas résisté à l'exorcisme.",
                _ => "L'état de Sameth est incertain..."
            };
        }
    }
}