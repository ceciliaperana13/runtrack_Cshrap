using System;
using System.Collections.Generic;
//logique
namespace EmbuscadeForet
{
        public class GestionnaireCombat
    {
        public string AnalyserMenace((ClasseEnnemi Classe, int Agressivite) attaquant)
        {
            return attaquant switch
            {
                (ClasseEnnemi.Mage, > 5)      => "Interrompre l'incantation en priorité",
                (ClasseEnnemi.Archer, _)      => "Se mettre à couvert",
                (ClasseEnnemi.Guerrier, <= 3) => "Esquiver et ignorer",
                _                              => "Défense standard"
            };
        }

        public void LancerCombat(Aventurier aventurier, List<Brigand> brigands)
        {
            Console.WriteLine("Le parchemin de Sameth vous a téléporté en pleine forêt...");
            Console.WriteLine($"{brigands.Count} brigands surgissent des fourrés !\n");

            foreach (var brigand in brigands)
            {
                var strategie = AnalyserMenace(brigand.VersTuple());
                aventurier.Riposter(strategie, brigand);
            }
        }
    }
}