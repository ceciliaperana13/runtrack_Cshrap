using System;
using System.Collections.Generic;
using System.Linq;

namespace SecoursVillage
{
    public static class Program
    {
        public static void Main()
        {
            // Sécurisation de la zone : évacuation d'urgence 
            var centre = new CentreDeCommandement();

            var secouristes = new List<Secouriste>
            {
                new Secouriste("Elowen"),
                new Secouriste("Tobias"),
                new Secouriste("Marion")
            };

            foreach (var secouriste in secouristes)
                centre.EnregistrerSecouriste(secouriste);

            centre.EnvoyerInstructionsEvacuation(
                "Évacuez le secteur nord, repli vers la place centrale !");

            Console.WriteLine();

            //  Premiers soins : calcul de l'efficacité via le délégué Heal
            CalculEfficaciteSoins calculerEfficacite = SoinsPremiersSecours.Heal;

            // Nombre de blessés arbitraire : le système doit en gérer n'importe combien.
            var blesses = new List<Blesse>
            {
                new Blesse("Villageois 1", gravite: 7),
                new Blesse("Villageois 2", gravite: 3),
                new Blesse("Villageois 3", gravite: 9),
                new Blesse("Villageois 4", gravite: 2),
                new Blesse("Villageois 5", gravite: 5),
            };

            const int fournituresDisponibles = 4;

            var soins = blesses
                .Select(b => (Blesse: b, Efficacite: calculerEfficacite(b.Gravite, fournituresDisponibles)))
                .OrderByDescending(s => s.Efficacite)
                .ToList();

            Console.WriteLine("Ordre de priorité des soins (par efficacité décroissante) :");
            foreach (var soin in soins)
            {
                Console.WriteLine(
                    $"  - {soin.Blesse.Nom} (gravité {soin.Blesse.Gravite}) -> efficacité des soins : {soin.Efficacite} PV récupérés");
            }
        }
    }
}