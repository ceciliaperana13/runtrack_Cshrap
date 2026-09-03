using System;

namespace EmbuscadeForet
{
    
    public abstract class Personnage
    {
        public string Nom { get; }
        public int PointsDeVie { get; protected set; }

        protected Personnage(string nom, int pointsDeVie)
        {
            Nom = nom;
            PointsDeVie = pointsDeVie;
        }

        public bool EstVivant => PointsDeVie > 0;

        public void SubirDegats(int degats)
        {
            PointsDeVie = Math.Max(0, PointsDeVie - degats);
        }
    }
}