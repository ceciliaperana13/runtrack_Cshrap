using System.Collections.Generic;

namespace EmbuscadeForet
{
    public static class Program
    {
        public static void Main()
        {
            var heros = new Aventurier("Kael");

            // Au moins 7 attaquants, chacun étant un objet Brigand
            // (dont on extrait le Tuple (Classe, Agressivité) pour l'analyse)
            var brigands = new List<Brigand>
            {
                new BrigandMage("Zoltar", agressivite: 8),     
                new BrigandMage("Yssaline", agressivite: 3),    
                new BrigandArcher("Rikko", agressivite: 6),     
                new BrigandArcher("Faelan", agressivite: 2),    
                new BrigandGuerrier("Bram", agressivite: 2),    
                new BrigandGuerrier("Orsk", agressivite: 7),    
                new BrigandVoleur("Nyx", agressivite: 4)       
            };

            var combat = new GestionnaireCombat();
            combat.LancerCombat(heros, brigands);
        }
    }
}