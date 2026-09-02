using System;

namespace Tartaros.Exploration
{
    //Sort qui bannit l'ombre avec des dégâts sacrés + restaure la clarté
    class PurifyingLightSpell : AntiShadowSpell
    {
        public PurifyingLightSpell() : base("Lumière Purificatrice", 12)
        {
        }

        public override void Cast(string target)
        {
            Console.WriteLine($"Une lumière sacrée jaillit et transperce {target}, lui infligeant de lourds dégâts sacrés.");
            Console.WriteLine("La pièce retrouve un peu de clarté, repoussant les ténèbres environnantes.");
        }
    }
}