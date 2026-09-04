using System;
using System.Collections.Generic;
using System.Linq;

namespace LiberationVictimes
{
    public static class Program
    {
        public static void Main()
        {
            // Nombre de victimes quelconque
            var victimes = new List<Victim>
            {
                new Victim("Garde Orik",     niveauMenace: 6, pointsDeVie: 40, estEnvoutee: true),
                new Victim("Aventurier Fen",  niveauMenace: 9, pointsDeVie: 55, estEnvoutee: true),
                new Victim("Garde Sella",     niveauMenace: 3, pointsDeVie: 30, estEnvoutee: false),
                new Victim("Aventurière Wren", niveauMenace: 8, pointsDeVie: 50, estEnvoutee: true),
                new Victim("Marchand Doran",  niveauMenace: 2, pointsDeVie: 20, estEnvoutee: true),
                new Victim("Garde Talia",     niveauMenace: 5, pointsDeVie: 35, estEnvoutee: false),
            };

            //Isoler les victimes encore sous l'emprise du miasme
            var victimesEnvoutees = victimes.Where(v => v.EstEnvoutee);

            //identifier
            var victimeLaPlusDangereuse = victimesEnvoutees
                .OrderByDescending(v => v.NiveauMenace)
                .First();

            //trier ces victimes par niveau
            var ordreDePurification = victimesEnvoutees
                .OrderByDescending(v => v.NiveauMenace)
                .ToList();

            Console.WriteLine($"{victimes.Count} personnes recensées sur place, dont {ordreDePurification.Count} encore sous l'emprise du miasme.");
            Console.WriteLine($"La plus dangereuse est {victimeLaPlusDangereuse.Nom} (menace {victimeLaPlusDangereuse.NiveauMenace}) : elle sera traitée en priorité.\n");

            Console.WriteLine("Vous et Meloap administrez l'encens de purification, dans l'ordre de dangerosité :");
            foreach (var victime in ordreDePurification)
            {
                victime.Purifier();
                Console.WriteLine($"  - {victime.Nom} (menace {victime.NiveauMenace}, {victime.PointsDeVie} PV) est apaisé(e) et libéré(e) du miasme.");
            }

            Console.WriteLine("\nToutes les victimes envoûtées ont été libérées sans être blessées.");
        }
    }
}