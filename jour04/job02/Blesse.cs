namespace SecoursVillage
{
    
    /// Un villageois blessé, en attente de premiers soins.
    public class Blesse
    {
        public string Nom { get; }
        public int Gravite { get; }

        public Blesse(string nom, int gravite)
        {
            Nom = nom;
            Gravite = gravite;
        }
    }
}