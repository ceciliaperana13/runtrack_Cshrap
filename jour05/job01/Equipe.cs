using System;

namespace CombatOrannis
{
    public class Equipe
    {
        public string Nom { get; }
        public int SanteGlobale { get; private set; }
        public int SanteMax { get; }

        public Meloap Meloap { get; }
        public Sameth Sameth { get; }
        public EgideDeTartaros Egide { get; }

        public Equipe(string nom, int santeInitiale)
        {
            Nom = nom;
            SanteGlobale = santeInitiale;
            SanteMax = santeInitiale;

            Meloap = new Meloap();
            Sameth = new Sameth();
            Egide = new EgideDeTartaros();

            // Abonnement à l'événement de l'Égide : chaque frappe absorbée
            // alimente automatiquement l'énergie accumulée.
            Egide.OnAuraAbsorbed += (expediteur, puissance) => Egide.AccumulerEnergie(puissance);
        }

        public void Soigner(int montant)
        {
            SanteGlobale = Math.Min(SanteMax, SanteGlobale + montant);
        }

        public void SubirDegats(int degats)
        {
            if (degats < 0)
                throw new CombatException("Tentative d'infliger des dégâts négatifs à l'équipe.");

            SanteGlobale -= degats;
            if (SanteGlobale < 0) SanteGlobale = 0;
        }

        public bool EstVivante => SanteGlobale > 0;
    }
}