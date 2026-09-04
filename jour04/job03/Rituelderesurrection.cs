using System;

namespace RituelOrannis
{
    
    public class RituelDeResurrection
    {
        public double MenaceTotale { get; private set; } = 0;

        public void FaireParticiper(Cultist cultiste, int manaRequis, IncantationSort incantation)
        {
            if (!cultiste.PeutIncanter(manaRequis))
            {
                Console.WriteLine($"  [{cultiste.Nom}] n'a pas assez de mana pour incanter et est écarté du rituel.");
                return;
            }

            double puissance = incantation(cultiste, manaRequis);
            cultiste.ConsommerMana(manaRequis);
            MenaceTotale += puissance;

            Console.WriteLine(
                $"  [{cultiste.Nom}] (niveau {cultiste.Niveau}) incante en consommant {manaRequis} mana " +
                $"-> puissance {puissance:F1} | Menace totale : {MenaceTotale:F1}");
        }
    }
}