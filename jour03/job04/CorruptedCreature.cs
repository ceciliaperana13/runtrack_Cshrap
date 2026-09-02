using System;

class CorruptedCreature
{
    public string Name { get; set;}
    public int Health { get;set;}
    public virtual void TakeMiasmaDamage(int damage)
    {
        this.Health -= damage;
        Console.WriteLine($"Nouveau montant de PV : {this.Health}");
    }
    // Construceur
    public CorruptedCreature(string name , int health)
    {
        this.Name = name;
        this.Health=health;
    }
}