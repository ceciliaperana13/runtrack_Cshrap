namespace CombatHedge
{
    /// Enregistre les informations d'un tour de combat, pour le journal et pour les vérifications LINQ en fin de combat.
    public class TourDeCombat
    {
        public int Numero { get; }
        public string Stance { get; }
        public bool IsCasting { get; }
        public string AttaqueChoisie { get; }
        public bool Adaptee { get; }
        public int ShieldPowerAvant { get; }
        public int ShieldPowerApres { get; }
        public double Contrecoup { get; }

        public TourDeCombat(int numero, string stance, bool isCasting, string attaqueChoisie,
            bool adaptee, int shieldPowerAvant, int shieldPowerApres, double contrecoup)
        {
            Numero = numero;
            Stance = stance;
            IsCasting = isCasting;
            AttaqueChoisie = attaqueChoisie;
            Adaptee = adaptee;
            ShieldPowerAvant = shieldPowerAvant;
            ShieldPowerApres = shieldPowerApres;
            Contrecoup = contrecoup;
        }
    }
}