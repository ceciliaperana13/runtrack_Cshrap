namespace EmbuscadeForet
{
    
    public abstract class Brigand : Personnage
    {
        public abstract ClasseEnnemi Classe { get; }
        public int Agressivite { get; }

        protected Brigand(string nom, int agressivite, int pointsDeVie = 30)
            : base(nom, pointsDeVie)
        {
            Agressivite = agressivite;
        }

        /// Représentation sous forme de Tuple (Classe, Agressivité),
        
        public (ClasseEnnemi Classe, int Agressivite) VersTuple() => (Classe, Agressivite);
    }

    public class BrigandMage : Brigand
    {
        public override ClasseEnnemi Classe => ClasseEnnemi.Mage;

        public BrigandMage(string nom, int agressivite) : base(nom, agressivite) { }
    }

    public class BrigandArcher : Brigand
    {
        public override ClasseEnnemi Classe => ClasseEnnemi.Archer;

        public BrigandArcher(string nom, int agressivite) : base(nom, agressivite) { }
    }

    public class BrigandGuerrier : Brigand
    {
        public override ClasseEnnemi Classe => ClasseEnnemi.Guerrier;

        public BrigandGuerrier(string nom, int agressivite) : base(nom, agressivite) { }
    }

    
    public class BrigandVoleur : Brigand
    {
        public override ClasseEnnemi Classe => ClasseEnnemi.Voleur;

        public BrigandVoleur(string nom, int agressivite) : base(nom, agressivite) { }
    }
}