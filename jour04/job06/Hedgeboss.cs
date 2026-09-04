using System;

namespace CombatHedge
{
    
    public class HedgeBoss
    {
        private static readonly string[] PosturesPossibles = { "Ombre", "Absorption", "Miasme" };

        public int ShieldPower { get; private set; } = 50;
        public bool EstDetruit => ShieldPower <= 0;

        private readonly Random rng;

        public HedgeBoss(int seed)
        {
            rng = new Random(seed);
        }

        /// Hedge change de posture au début de son tour et renvoie l'état
        public (string Stance, int ShieldPower, bool IsCasting) ChangerPosture()
        {
            string stance = PosturesPossibles[rng.Next(PosturesPossibles.Length)];
            bool isCasting = stance == "Miasme"; // Hedge incante toujours en posture Miasme

            return (stance, ShieldPower, isCasting);
        }

        public void ModifierPuissance(int delta)
        {
            ShieldPower = Math.Max(0, ShieldPower + delta);
        }
    }
}