using System;

namespace CombatHedge
{
    ///logique 
    public static class LogiqueDeCombat
    {
        private static readonly string[] AttaquesPossibles =
            { "Sort", "Attaque physique", "Égide de Tartaros" };

       
        public static readonly Func<int, double> CalculerContrecoup = shieldPower => shieldPower * 0.3;

   
        public static string DeterminerRiposteIdeale((string Stance, int ShieldPower, bool IsCasting) etat)
        {
            return etat switch
            {
                ("Miasme", _, true) => "Égide de Tartaros",
                ("Ombre", _, _) => "Sort",
                ("Absorption", _, _) => "Attaque physique",
                _ => "Attaque physique"
            };
        }

        public static string ChoisirAttaque((string Stance, int ShieldPower, bool IsCasting) etat, Random rng)
        {
            string riposteIdeale = DeterminerRiposteIdeale(etat);

            if (rng.NextDouble() < 0.25)
            {
                var autresChoix = Array.FindAll(AttaquesPossibles, a => a != riposteIdeale);
                return autresChoix[rng.Next(autresChoix.Length)];
            }

            return riposteIdeale;
        }
    }
}