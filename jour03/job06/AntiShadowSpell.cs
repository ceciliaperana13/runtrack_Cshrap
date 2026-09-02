using System;

namespace Tartaros.Exploration
{
    //Classe abstraite sort anti-ombre
    abstract class AntiShadowSpell
    {
        public string Name { get; }
        public int ManaCost { get; }

        //Constructeur
        public AntiShadowSpell(string name, int manaCost)
        {
            this.Name = name;
            this.ManaCost = manaCost;
        }

        //methode abstraite : chaque sort doit définir son propre effet
        public abstract void Cast(string target);

        //methode concrète : vérifie si le mana disponible suffit
        public bool CanCast(int currentMana)
        {
            return currentMana >= ManaCost;
        }
    }
}