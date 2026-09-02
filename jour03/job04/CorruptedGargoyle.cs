using System;
//avec overide la gargouille étant en pierre, elle réduit les dégâts reçus de la valeur de son armorValue.
class CorruptedGargoyle : CorruptedCreature

{
    public int ArmorValue {get;set;} = 3;
    public CorruptedGargoyle
(string name,int health,int armorValue) : base(name,health)
    {
        this.ArmorValue = armorValue;
        this.Name =name;
        this.Health = health;
    }
    // override de la méthode TakeMiasmaDamage pour réduire les dégâts reçus de la valeur de l'armorValue.
    public override void TakeMiasmaDamage(int damage)
    {
        int reducedDamage = damage-ArmorValue;
        if (reducedDamage <0)
        {
            reducedDamage = 0;
        }
        this.Health -= reducedDamage;
        Console.WriteLine("La gargouille réduit les dégâts reçus!");
    }
}    