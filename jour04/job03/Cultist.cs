namespace RituelOrannis
{
    
    public class Cultist
    {
        public string Nom { get; }
        public int Vie { get; private set; }
        public int Mana { get; private set; }
        public int Niveau { get; }

        public Cultist(string nom, int vie, int mana, int niveau)
        {
            Nom = nom;
            Vie = vie;
            Mana = mana;
            Niveau = niveau;
        }

        public bool PeutIncanter(int manaRequis) => Mana >= manaRequis;

        public void ConsommerMana(int manaRequis)
        {
            Mana -= manaRequis;
        }
    }
}