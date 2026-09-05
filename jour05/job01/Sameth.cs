using System;
using System.Collections.Generic;

namespace CombatOrannis
{
  
    public class Sameth
    {
        public Dictionary<string, int> Inventaire { get; } = new Dictionary<string, int>
        {
            { "ObjetSoutien", 3 }, // 3 objets de soutien utilisables à chaque tour (Phase 1)
            { "Potion", 3 }       // 3 potions de soin disponibles pour toute la Phase 2
        };

        
        public int AppliquerObjetsSoutien()
        {
            if (!Inventaire.ContainsKey("ObjetSoutien") || Inventaire["ObjetSoutien"] <= 0)
                throw new CombatException("Sameth ne dispose d'aucun objet de soutien !");

            int nbObjets = Inventaire["ObjetSoutien"];
            int bonus = nbObjets * 10;
            Console.WriteLine($"  [Sameth] {nbObjets} objet(s) de soutien fourni(s) -> +{bonus} points");
            return bonus;
        }

      
        /// Soigne l'équipe automatiquement si la santé est critique (<= 40).
        public bool Soigner(Equipe groupe)
        {
            const int seuilCritique = 40;
            const int soinPotion = 30;

            if (groupe.SanteGlobale > seuilCritique)
                return false; // santé pas critique, aucune action nécessaire

            if (!Inventaire.ContainsKey("Potion") || Inventaire["Potion"] <= 0)
                throw new CombatException("Sameth n'a plus de potions disponibles alors que l'équipe est en danger critique !");

            Inventaire["Potion"]--;
            groupe.Soigner(soinPotion);
            Console.WriteLine($"  [Sameth] Potion utilisée (restantes : {Inventaire["Potion"]}) -> +{soinPotion} PV pour l'équipe");
            return true;
        }
    }
}