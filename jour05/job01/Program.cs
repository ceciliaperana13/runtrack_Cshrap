using System;
using System.Collections.Generic;

namespace CombatOrannis
{
    
    public static class Program
    {
        // Les 3 attaques d'Orannis en Phase 2, représentées par des tuples (nom, puissance)
        private static readonly List<(string Nom, int Puissance)> AttaquesOrannis = new List<(string, int)>
        {
            ("Souffle de Démence", 40),
            ("Écrasement", 80),
            ("Frappe obscure", 30)
        };

        public static void Main(string[] args)
        {
            Console.WriteLine("############################################");
            Console.WriteLine("#     COMBAT CONTRE ORANNIS - SCÉNARIO 1  #");
            Console.WriteLine("#           (déroulement normal)          #");
            Console.WriteLine("############################################\n");
            LancerCombat(seedAleatoire: 42, sansPotions: false);

            Console.WriteLine("\n\n############################################");
            Console.WriteLine("#     COMBAT CONTRE ORANNIS - SCÉNARIO 2  #");
            Console.WriteLine("#   (test de défaite - Sameth sans potion) #");
            Console.WriteLine("############################################\n");
            LancerCombat(seedAleatoire: 7, sansPotions: true);
        }

        
        private static void LancerCombat(int seedAleatoire, bool sansPotions)
        {
            var equipe = new Equipe("Les Héros", 100);
            var orannis = new Orannis(1000);
            var rng = new Random(seedAleatoire);

            if (sansPotions)
            {
                equipe.Sameth.Inventaire["Potion"] = 0;
                Console.WriteLine("[Scénario] Sameth commence ce combat sans aucune potion !\n");
            }

            try
            {
                
                Console.WriteLine(" PHASE 1 : L'Ombre d'Orannis ");
                int tour = 1;

                while (!orannis.EstEnPhase2 && !orannis.EstVaincu)
                {
                    Console.WriteLine($"\n Tour {tour} (Phase 1) ");

                    // Soutiens de Meloap filtrés par LINQ
                    int puissanceMeloap = equipe.Meloap.ExecuterSoutiensFiltres();

                    // Bonus des objets de soutien de Sameth
                    int bonusSameth = equipe.Sameth.AppliquerObjetsSoutien();

                    int puissanceSoutienTotale = puissanceMeloap + bonusSameth;

                    // Orannis lance une frappe de puissance 20, absorbée par l'Égide
                    equipe.Egide.AbsorberFrappe(20);

                    //Calcul des dégâts infligés à Orannis
                    int degatsInfliges = puissanceSoutienTotale + equipe.Egide.Energie;
                    orannis.SubirDegats(degatsInfliges);

                    Console.WriteLine($"  => Puissance de soutien totale : {puissanceSoutienTotale} | Énergie Égide : {equipe.Egide.Energie}");
                    Console.WriteLine($"  => Orannis subit {degatsInfliges} dégâts. PV Orannis : {orannis.PointsDeVie}/{orannis.PointsDeVieMax}");

                    tour++;
                }

                if (orannis.EstVaincu)
                {
                    Console.WriteLine("\n*** Orannis est vaincu dès la Phase 1 ! VICTOIRE ! ***");
                    return;
                }

                Console.WriteLine($"\nOrannis est descendu à {orannis.PointsDeVie} PV (<= 50%). Passage en Phase 2 !");

                //phase2
                Console.WriteLine("\n=== PHASE 2 : Orannis le Libéré ===");
                equipe.Egide.Reinitialiser();
                tour = 1;

                while (!orannis.EstVaincu && equipe.EstVivante)
                {
                    Console.WriteLine($"\n--- Tour {tour} (Phase 2) ---");
                    Console.WriteLine($"  PV Équipe : {equipe.SanteGlobale}/{equipe.SanteMax} | PV Orannis : {orannis.PointsDeVie}/{orannis.PointsDeVieMax}");

                    // Choix de l'attaque d'Orannis (au hasard)
                    var attaque = AttaquesOrannis[rng.Next(AttaquesOrannis.Count)];
                    Console.WriteLine($"  Orannis utilise : \"{attaque.Nom}\" (puissance {attaque.Puissance})");

                    // Pattern Matching sur le Tuple pour déterminer la réaction de l'équipe
                    switch (attaque)
                    {
                        case ("Souffle de Démence", _):
                            Console.WriteLine("  [Réaction] L'Égide déclenche une onde de protection et absorbe le souffle !");
                            equipe.Egide.AbsorberFrappe(attaque.Puissance);
                            // Dégâts annulés : l'équipe ne subit rien
                            break;

                        case ("Écrasement", var puissance) when puissance > 50:
                            int degatsReduits = attaque.Puissance - 20;
                            Console.WriteLine($"  [Réaction] Meloap dresse sa défense écailleuse. Dégâts réduits de 20 -> {degatsReduits}");
                            equipe.SubirDegats(degatsReduits);
                            break;

                        default:
                            Console.WriteLine("  [Réaction] Assaut général combiné !");
                            equipe.SubirDegats(attaque.Puissance);
                            int degatsRiposte = 30 + equipe.Egide.Energie;
                            orannis.SubirDegats(degatsRiposte);
                            Console.WriteLine($"  => L'équipe riposte pour {degatsRiposte} dégâts (30 + énergie Égide {equipe.Egide.Energie})");
                            break;
                    }

                    // Vérification de l'équipe après l'attaque
                    if (!equipe.EstVivante)
                    {
                        Console.WriteLine($"  PV Équipe : {equipe.SanteGlobale}/{equipe.SanteMax} | PV Orannis : {orannis.PointsDeVie}/{orannis.PointsDeVieMax}");
                        break;
                    }

                    // Soin automatique de Sameth si santé critique (<= 40)
                    equipe.Sameth.Soigner(equipe);

                    Console.WriteLine($"  PV Équipe : {equipe.SanteGlobale}/{equipe.SanteMax} | PV Orannis : {orannis.PointsDeVie}/{orannis.PointsDeVieMax}");

                    tour++;
                }

                //resul
                Console.WriteLine("\n=====================================");
                if (orannis.EstVaincu)
                    Console.WriteLine(" VICTOIRE ! Orannis a été définitivement vaincu !");
                else
                    Console.WriteLine(" DÉFAITE ! L'équipe a succombé face à Orannis...");
                Console.WriteLine("=====================================");
            }
            catch (CombatException ex)
            {
                Console.WriteLine($"\n[ERREUR DE COMBAT] {ex.Message}");
                Console.WriteLine("Le combat est interrompu suite à une action invalide.");
            }
        }
    }
}