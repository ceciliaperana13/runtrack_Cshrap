namespace LiberationVictimes
{
    /// Une victime de la démence provoquée par le miasme du mage maudit.
    public class Victim
    {
        public string Nom { get; }
        public int NiveauMenace { get; }
        public int PointsDeVie { get; private set; }
        public bool EstEnvoutee { get; private set; }

        public Victim(string nom, int niveauMenace, int pointsDeVie, bool estEnvoutee)
        {
            Nom = nom;
            NiveauMenace = niveauMenace;
            PointsDeVie = pointsDeVie;
            EstEnvoutee = estEnvoutee;
        }

        
        public void Purifier()
        {
            EstEnvoutee = false;
        }
    }
}