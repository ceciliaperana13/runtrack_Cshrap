using System;

namespace CombatOrannis
{
    public class EgideDeTartaros
    {
        public int Energie { get; private set; } = 0;

        // Événement déclenché lorsqu'une frappe est absorbée
        public event EventHandler<int> OnAuraAbsorbed;

        
        /// Absorbe une frappe d'une certaine puissance et déclenche
        public void AbsorberFrappe(int puissance)
        {
            Console.WriteLine($"  [Égide] Frappe absorbée (puissance {puissance})");
            OnAuraAbsorbed?.Invoke(this, puissance);
        }

        
        public void AccumulerEnergie(int puissanceAbsorbee)
        {
            Energie += puissanceAbsorbee;
            Console.WriteLine($"  [Égide] Énergie accumulée : {Energie}");
        }

        /// Remet l'énergie de l'Égide à zéro
        public void Reinitialiser()
        {
            Energie = 0;
        }
    }
}