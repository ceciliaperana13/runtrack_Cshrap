using System;

namespace Tartaros.Exploration
{
    //sort qui frappe la structure magique de l'ombre pour la faire exploser
    class DisruptionWaveSpell : AntiShadowSpell
    {
        public DisruptionWaveSpell() : base("Onde de Perturbation", 18)
        {
        }

        public override void Cast(string target)
        {
            Console.WriteLine($"Une onde instable percute la structure magique de {target}...");
            Console.WriteLine($"{target} se disloque et explose dans un éclat d'énergie chaotique !");
        }
    }
}