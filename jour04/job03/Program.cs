using System;
using System.Collections.Generic;

namespace RituelOrannis
{
    public static class Program
    {
        public static void Main()
        {
            // Expression lambda définissant la logique du sort :
            IncantationSort sortDuRituel = (cultiste, manaRequis) => cultiste.Niveau * manaRequis * 1.5;

            var rituel = new RituelDeResurrection();

            var cultistes = new List<Cultist>
            {
                new Cultist("Marrek",  vie: 40, mana: 30, niveau: 4),
                new Cultist("Ysolde",  vie: 35, mana: 50, niveau: 6),
                new Cultist("Corvin",  vie: 50, mana: 20, niveau: 3),
                new Cultist("Naeris",  vie: 45, mana: 60, niveau: 7),
                new Cultist("Thal",    vie: 30, mana: 10, niveau: 2),
            };

            Console.WriteLine("Les cultistes forment un cercle autour de Hedge et entament le rituel...\n");

            foreach (var cultiste in cultistes)
            {
                int manaRequis = cultiste.Niveau * 3; // coût du sort proportionnel au niveau
                rituel.FaireParticiper(cultiste, manaRequis, sortDuRituel);
            }

            Console.WriteLine($"\nLe rituel s'intensifie... Menace totale finale : {rituel.MenaceTotale:F1}");
        }
    }
}