using System;

// possèdant une propriété supplémentaire armorValue. Son constructeur doit réutiliser le constructeur de CorruptedCreature pour initialiser le nom et la santé, sans réécrirel'assignation de ces champs.
class CorruptedGargoyle : CorruptedCreature
{
    public int ArmorValue {get; set;}
    public CorruptedGargoyle(string name,int health,int armorValue) : base(name,health)
    {
        this.ArmorValue = armorValue;
    }

        
}