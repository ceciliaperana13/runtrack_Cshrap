namespace SecoursVillage
{
    //logique
    public static class SoinsPremiersSecours
    {
        
        /// Calcule l'efficacité des premiers soins apportés à un blessee
        public static int Heal(int graviteBlessure, int quantiteFournitures)
        {
            return graviteBlessure * quantiteFournitures;
        }
    }
}