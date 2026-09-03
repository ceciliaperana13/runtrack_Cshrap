using System;

namespace EmbuscadeForet
{
    
    public class Aventurier : Personnage
    {
        public Aventurier(string nom, int pointsDeVie = 100) : base(nom, pointsDeVie) { }

        public void Riposter(string strategie, Brigand cible)
        {
            Console.WriteLine(
                $"  -> {Nom} face à {cible.Nom} ({cible.Classe}, agressivité {cible.Agressivite}) : {strategie}");
        }
    }
}