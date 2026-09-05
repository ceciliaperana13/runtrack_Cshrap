namespace CombatOrannis
{//boss
    public class Orannis
    {
        public int PointsDeVieMax { get; }
        public int PointsDeVie { get; private set; }

        public Orannis(int pointsDeVieInitiaux)
        {
            PointsDeVieMax = pointsDeVieInitiaux;
            PointsDeVie = pointsDeVieInitiaux;
        }

        public void SubirDegats(int degats)
        {
            if (degats < 0)
                throw new CombatException("Tentative d'infliger des dégâts négatifs à Orannis.");

            PointsDeVie -= degats;
            if (PointsDeVie < 0) PointsDeVie = 0;
        }

        public bool EstVaincu => PointsDeVie <= 0;

        public bool EstEnPhase2 => PointsDeVie <= PointsDeVieMax / 2;
    }
}