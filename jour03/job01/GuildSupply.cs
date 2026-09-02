using System;
using System.Collections.Generic;

namespace Tartaros.Exploration
{
    class GuildSupply
    {
        public string Name { get; set; }

        //  Propriété contenant une liste de noms d'objets consommables
        public List<string> ConsumableItems { get; set; }

        //  Constructeur qui initialise directement avec 3 objets au choix
        public GuildSupply(string name)
        {
            this.Name = name;
            this.ConsumableItems = new List<string>
            {
                "Potion de soin",
                "Potion de mana",
                "Potion de force"
            };
        }
    }
}