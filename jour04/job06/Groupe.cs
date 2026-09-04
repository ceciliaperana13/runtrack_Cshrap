namespace CombatHedge
{
    /// Le groupe d'aventuriers affrontant Hedge, susceptible de subir le contrecoup du Miasme Miroir.
    public class Groupe
    {
        public int PointsDeVie { get; private set; } = 100;

        public void SubirContrecoup(double degats)
        {
            PointsDeVie -= (int)degats;
            if (PointsDeVie < 0) PointsDeVie = 0;
        }
    }
}