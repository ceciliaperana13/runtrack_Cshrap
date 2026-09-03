namespace SecoursVillage
{
    
    /// Délégué permettant d'envoyer une instruction d'évacuation d'urgence
    public delegate void InstructionEvacuation(string message);

    
    public delegate int CalculEfficaciteSoins(int graviteBlessure, int quantiteFournitures);
}