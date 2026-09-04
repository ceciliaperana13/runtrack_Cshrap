using System;

namespace ExorcismeSameth
{
    public static class Program
    {
        public static void Main()
        {
            var etat = (PhysicalHealth: 100, CorruptionLevel: 50, IsConscious: true);

            Console.WriteLine("Vous brandissez L'Égide de Tartaros face à Sameth, encore habité par Hedge.");
            Console.WriteLine($"État initial : santé={etat.PhysicalHealth}, corruption={etat.CorruptionLevel}, conscient={etat.IsConscious}\n");

            int tour = 1;

            while (true)
            {
                if (etat.IsConscious)
                {
                    Console.WriteLine($"Tour {tour} : vous appliquez L'Égide de Tartaros sur Sameth.");
                    etat = Exorciseur.Exorcise(etat);
                }
                else
                {
                    Console.WriteLine($"Tour {tour} : Sameth est inconscient, impossible d'agir ; il reprend quelques forces.");
                    etat = Exorciseur.PasserSansAction(etat);
                }

                string diagnostic = Exorciseur.AnalyserEtat(etat);

                Console.WriteLine($"  État : santé={etat.PhysicalHealth}, corruption={etat.CorruptionLevel}, conscient={etat.IsConscious}");
                Console.WriteLine($"  -> {diagnostic}\n");

                bool libere = etat.PhysicalHealth > 0 && etat.CorruptionLevel <= 0;
                bool mort = etat.PhysicalHealth <= 0;

                if (libere || mort)
                    break;

                tour++;
            }
        }
    }
}